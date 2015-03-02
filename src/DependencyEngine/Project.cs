using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml;
using System.Reflection;

namespace DependencyEngine
{
    /// <summary>
    /// A msbuild compatible project
    /// </summary>
    public class Project
    {
        private string name;
        private string path;
        private Guid guid;
        private Guid projectType;
        private Collection<Project> projectReferences;
        private Collection<AssemblyProject> references;
        private List<Guid> projectDependencyGuids;
        private string assemblyName;
        readonly List<MissingProject> missingReferences = new List<MissingProject>();

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        public Project()
        {
            references = new Collection<AssemblyProject>();
            projectReferences = new Collection<Project>();
            projectDependencyGuids = new List<Guid>();
            assemblyName = "Assembly Name Not set";
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds a project dependency.
        /// </summary>
        /// <param name="guid">The GUID of the project depended on.</param>
        public void AddProjectDependency(string guid)
        {
            projectDependencyGuids.Add(new Guid(guid));
        }

        #endregion

        #region Public static methods

        /// <summary>
        /// Gets the project kind.
        /// </summary>
        /// <param name="projectGuid">The project type GUID.</param>
        /// <returns></returns>
        public static ProjectKind GetKind(Guid projectGuid)
        {
            foreach (ProjectKind kind in Enum.GetValues(typeof(ProjectKind)))
            {
                FieldInfo field = kind.GetType().GetField(kind.ToString());
                if (projectGuid == new Guid(((DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description))
                {
                    return kind;
                }
            }
            return ProjectKind.Unknown;
        }


        #endregion

        #region Overriden methods

        public override string ToString()
        {
            return this.Name;
        }

        #endregion

        #region Properties

        [Description("The AssemblyName of the project. This is used to find references to at specific project, through .dll reference only.")]
        [Category("General")]
        public string AssemblyName
        {
            get { return assemblyName; }
            set { assemblyName = value; }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Description("The name of the project. Only used for display purpose.")]
        [Category("General")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        [Category("General")]
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        /// <summary>
        /// Gets or sets the GUID.
        /// </summary>
        /// <value>The GUID.</value>
        [Category("General")]
        public Guid Guid
        {
            get { return guid; }
            set
            {
                guid = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the project.
        /// </summary>
        /// <value>The type of the project.</value>
        [Category("General")]
        [Browsable(false)]
        public Guid ProjectType
        {
            get { return projectType; }
            set { projectType = value; }
        }

        [Browsable(false)]
        public ProjectKind ProjectKind
        {
            get { return Project.GetKind(this.ProjectType); }
        }


        /// <summary>
        /// Gets the project references.
        /// </summary>
        /// <value>The project references.</value>
        [Category("References")]
        public Collection<Project> ProjectReferences
        {
            get { return projectReferences; }
        }


        /// <summary>
        /// Gets or sets the references.
        /// </summary>
        /// <value>The references.</value>
        [Category("References")]
        public Collection<AssemblyProject> References
        {
            get { return references; }
        }

        public List<MissingProject> MissingReferences
        {
            get { return missingReferences; }
        }

        #endregion
    }

    #region Enums
    /// <summary>
    /// Project kind
    /// </summary>
    public enum ProjectKind
    {
        /// <summary>
        /// Unknown project type
        /// </summary>
        [Description("{00000000-0000-0000-0000-000000000000}")]
        Unknown,
        /// <summary>
        /// C# project
        /// </summary>
        [Description("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}")]
        CSharp,
        /// <summary>
        /// VB.NET project
        /// </summary>
        [Description("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}")]
        VBNet,
        /// <summary>
        /// Solution folder
        /// </summary>
        [Description("{2150E333-8FDC-42A3-9474-1A3956D46DE8}")]
        SolutionItems,
        /// <summary>
        /// Setup project
        /// </summary>
        [Description("{54435603-DBB4-11D2-8724-00A0C9A8B90C}")]
        Setup,
        /// <summary>
        /// C++ project
        /// </summary>
        [Description("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}")]
        Cpp,
        /// <summary>
        /// J# project
        /// </summary>
        [Description("{E6FDF86B-F3D1-11D4-8576-0002A516ECE8}")]
        JSharp,
        /// <summary>
        /// Web project 
        /// </summary>
        [Description("{E24C65DC-7377-472b-9ABA-BC803B73C61A}")]
        WebProject,
        /// <summary>
        /// WiX project
        /// </summary>
        [Description("{930C7802-8A8C-48F9-8165-68863BCCD9DD}")]
        Wix
    }
    #endregion
}
