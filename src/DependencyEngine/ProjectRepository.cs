using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace DependencyEngine
{
    /// <summary>
    /// Project repository
    /// </summary>
    public class ProjectRepository
    {
        private Dictionary<Guid, Project> projectCollection;
        private Dictionary<string, AssemblyProject> assemblyProjectCollection;


        private static readonly ProjectRepository m_instance = new ProjectRepository();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRepository"/> class.
        /// </summary>
        public ProjectRepository()
        {
            projectCollection = new Dictionary<Guid, Project>();
            assemblyProjectCollection = new Dictionary<string, AssemblyProject>();
        }

        #region Public methods

        /// <summary>
        /// Gets the project by GUID.
        /// </summary>
        /// <param name="guid">The project GUID.</param>
        /// <returns>the specified project or <c>null</c> if specified project does not yet exist</returns>
        public Project GetByGuid(Guid guid)
        {
            if (projectCollection.ContainsKey(guid))
            {
                return projectCollection[guid];
            }
            return null;
        }

        public AssemblyProject GetByGuid(string id)
        {
            if (assemblyProjectCollection.ContainsKey(id))
            {
                return assemblyProjectCollection[id];
            }
            return null;
        }

        /// <summary>
        /// Creates and Adds the specified project to the repository.
        /// Only if it's not already in the repository!
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        public void Add(string projectPath)
        {
            Add(FromFile(projectPath));
        }

        /// <summary>
        /// Adds the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void Add(Project project)
        {
            if (projectCollection.ContainsKey(project.Guid))
            {
                project.Name += " - Copy";
                project.Guid = Guid.NewGuid();
            }

            projectCollection[project.Guid] = project;
        }

        public void Add(AssemblyProject assemblyProject)
        {
            //ToDo: Save if it has another version no.
            if (!assemblyProjectCollection.ContainsKey(assemblyProject.Id))
            {
                assemblyProjectCollection[assemblyProject.Id] = assemblyProject;
            }
        }

        /// <summary>
        /// Create a project from file
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <param name="solution">The parent solution.</param>
        /// <returns>a partially parsed project</returns>
        public Project FromFile(string projectPath)
        {
            ////Tracer.Debug("Pre-parsing {0} ...", projectPath);
            Project project = new Project();

            XmlDocument doc = new XmlDocument();
            doc.Load(projectPath);
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("msbuild", "http://schemas.microsoft.com/developer/msbuild/2003");

            var nameNode = doc.SelectSingleNode("/msbuild:Project/msbuild:PropertyGroup/msbuild:AssemblyName/text()", ns)
                           ?? doc.SelectSingleNode("/msbuild:Project/msbuild:PropertyGroup/msbuild:Name/text()", ns);

            project.Name = nameNode.Value;
            project.AssemblyName = project.Name;
            project.ProjectType = Guid.Empty; // TODO: fix project type guid somehow
            project.Guid = new Guid(doc.SelectSingleNode("/msbuild:Project/msbuild:PropertyGroup/msbuild:ProjectGuid/text()", ns).Value);
            project.Path = System.IO.Path.GetFullPath(projectPath);


            foreach (XmlAttribute att in doc.SelectNodes("/msbuild:Project/msbuild:ItemGroup/msbuild:Reference/@Include", ns))
            {
                //ToDo: Also get the version number
                string[] attributes = att.Value.Split(',');
                string name = attributes[0];
                string version = "";
                string culture = "";
                string publicKeyToken = "";

                //If there is a version number we use it
                if (attributes.Count() >= 2)
                    version = attributes[1].Replace("Version=", "").Trim();
                if (attributes.Count() >= 3)
                    culture = attributes[2].Replace("Culture=", "").Trim();
                if (attributes.Count() >= 4)
                    publicKeyToken = attributes[3].Replace("PublicKeyToken=", "").Trim();

                AssemblyProject assemblyP = new AssemblyProject(name, version, culture, publicKeyToken);

                //Check if the AssemblyProject all ready exists.
                if (GetByGuid(assemblyP.Id) != null)
                {
                    assemblyP = GetByGuid(assemblyP.Id);
                }
                project.References.Add(assemblyP);

                //Add the referenced file as a AssemblyProject
                ProjectRepository.Instance.Add(assemblyP);
            }

            foreach (XmlElement el in doc.SelectNodes("/msbuild:Project/msbuild:ItemGroup/msbuild:ProjectReference", ns))
            {
                Project p = ProjectRepository.Instance.GetByGuid(new Guid(el.SelectSingleNode("msbuild:Project/text()", ns).Value));
                if (p != null)
                {
                    project.ProjectReferences.Add(p);
                }
                else
                {
                    try
                    {
                        p = ProjectRepository.Instance.FromFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(project.Path), el.SelectSingleNode("@Include", ns).Value));
                        project.ProjectReferences.Add(p);
                    }
                    catch (IOException)
                    {
                        project.MissingReferences.Add(new MissingProject(el.SelectSingleNode("@Include", ns).Value, el.SelectSingleNode("msbuild:Project/text()", ns).Value));
                    }
                }
            }
            return project;
        }

        public void Clear()
        {
            projectCollection.Clear();
            assemblyProjectCollection.Clear();
        }

        #endregion

        #region Public static properties

        /// <summary>
        /// Gets the repository instance.
        /// </summary>
        /// <value>The instance.</value>
        public static ProjectRepository Instance
        {
            get { return m_instance; }
        }

        #endregion

        #region Properties

        public Dictionary<Guid, Project> ProjectDictionary
        {
            get { return projectCollection; }
            set { projectCollection = value; }
        }

        public List<Project> ProjectList
        {
            get
            {
                List<Project> list = new List<Project>();

                foreach (Guid key in projectCollection.Keys)
                {
                    list.Add(projectCollection[key]);
                }

                list.Sort(delegate(Project x, Project y) { return String.Compare(x.ToString(), y.ToString()); });

                return list;
            }
        }

        public List<AssemblyProject> AssemblyProjectList
        {
            get
            {
                List<AssemblyProject> list = new List<AssemblyProject>();

                foreach (string key in assemblyProjectCollection.Keys)
                {
                    list.Add(assemblyProjectCollection[key]);
                }

                list.Sort(delegate(AssemblyProject x, AssemblyProject y) { return String.Compare(x.ToString(), y.ToString()); });

                return list;
            }
        }

        #endregion
    }

    public class MissingProject
    {
        readonly string project;
        readonly Guid guid;

        public MissingProject(string project, string guid)
        {
            this.project = project;
            this.guid = new Guid(guid);
        }

        public string Project
        {
            get { return project; }
        }

        public Guid Guid
        {
            get { return guid; }
        }
    }
}
