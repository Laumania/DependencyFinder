using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DependencyEngine;
using DependencyVisualizer;
using Project = DependencyEngine.Project;
using ProjectRepository = DependencyEngine.ProjectRepository;

namespace DependencyFinder.Forms
{
    public partial class MainForm : Form
    {
        private List<string> filePaths = new List<string>();
        //private string path;
        private bool progressCancelled = false;
        private delegate void WriteToConsole(string text);

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            //Get rootpath from Settings, so the application can remember the users last path
            rootPathToolStripTextBox.Text = Properties.Settings.Default.RootPath;

            //Set the different controls texts
            versionToolStripStatusLabel.Text = "v" +Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
        } 

        #endregion

        #region Private methods

        private void GetProjectFiles(string rootPath)
        {
            if (Directory.Exists(rootPath) && !progressCancelled)
            {
                string[] dirs = Directory.GetDirectories(rootPath);
                if (dirs.Length > 0 && !progressCancelled)
                {
                    foreach (string dir in dirs)
                    {
                        GetProjectFiles(dir);

                        //Cancelled the process
                        if (progressCancelled)
                            break;
                    }

                    foreach (string file in Directory.GetFiles(rootPath))
                    {
                        if (Path.GetExtension(file).ToLower().Equals(".csproj"))
                        {
                            filePaths.Add(file);
                        }

                        //Cancelled the process
                        if (progressCancelled)
                            break;
                    }
                }
            }
        } 
        #endregion

        #region Private event handlers

        private void collectDateButton_Click(object sender, EventArgs e)
        {
            if (rootPathToolStripTextBox.Text != "")
            {
                cancelToolStripButton.Enabled = true;
                startCollectDataToolStripButton.Enabled = false;
                

                //Save the rootpath in Settings
                Properties.Settings.Default.RootPath = rootPathToolStripTextBox.Text;
                Properties.Settings.Default.Save();

                toolStripStatusLabel1.Text = "Collecting data...";
                toolStripProgressBar1.Visible = true;
                toolStripProgressBar1.Value = 0;

                //Start the backgroundworker that will start collecting the data
                dateCollecterBackgroundWorker.RunWorkerAsync();
            }
            else
                MessageBox.Show("You need to pick a \"Root\" folder before collecting data\nPush the 'Browse' button in the top.", "Root path are missing");
        }

        private void cancelToolStripButton_Click(object sender, EventArgs e)
        {
            dateCollecterBackgroundWorker.CancelAsync();
            progressCancelled = true;
        }

        private void projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            Project selectedProject = new Project();
            List<Project> result = new List<Project>();

            if (list.SelectedItem != null)
            {
                selectedProject = list.SelectedItem as Project;
                projectPropertyGrid.SelectedObject = ProjectRepository.Instance.GetByGuid(selectedProject.Guid);
            }

            //Figure out how many has a reference to this
            foreach (KeyValuePair<Guid, Project> project in ProjectRepository.Instance.ProjectDictionary.ToList())
            {
                if (project.Value.ProjectReferences.Contains(selectedProject))
                {
                    result.Add(project.Value);
                    Console.WriteLine("ProjectReference: " + selectedProject.Name);
                }
                else
                {
                    //Check if the current project have a refence to this projects .dll file
                    foreach (Project refProject in project.Value.ProjectReferences)
                    {
                        if (refProject.AssemblyName.Equals(selectedProject.AssemblyName, StringComparison.InvariantCultureIgnoreCase))
                            result.Add(project.Value);
                    }
                }
            }

            referencesListBox.DataSource = selectedProject.References;
            projectReferencesListBox.DataSource = selectedProject.ProjectReferences;
            referenceProjectsListBox.DataSource = result;
            projectCaptionLabel.Text = "Project: " + selectedProject.Name;
            projectPathLabel.Text = "Project path: " + selectedProject.Path;
        }

        private void assemblyProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            AssemblyProject selectedAssemblyProject = new AssemblyProject("Unknown");//, "Unknown");

            if (list.SelectedItem != null)
            {
                selectedAssemblyProject = list.SelectedItem as AssemblyProject;
                projectPropertyGrid.SelectedObject = ProjectRepository.Instance.GetByGuid(selectedAssemblyProject.Id);
            }

            List<Project> result = new List<Project>();
            
            //Figure out how many has a reference to this
            foreach (Project project in ProjectRepository.Instance.ProjectList)
            {
                if (project.References.Contains(selectedAssemblyProject))
                {
                    result.Add(project);
                }
            }

            referenceProjectsListBox.DataSource = result;
            projectCaptionLabel.Text = "Assembly name: " + selectedAssemblyProject.Name;
            projectPathLabel.Text = "Version: " + selectedAssemblyProject.Version;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = rootPathFolderBrowserDialog.ShowDialog(this);
            rootPathToolStripTextBox.Text = rootPathFolderBrowserDialog.SelectedPath;

            //Save the selected path
            Properties.Settings.Default.RootPath = rootPathFolderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void projectReferencesListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            projectPropertyGrid.SelectedObject = listBox.SelectedItem as Project;
        }

        private void assemblyProjectReferencesListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            projectPropertyGrid.SelectedObject = listBox.SelectedItem as AssemblyProject;
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            ProjectRepository.Instance.Clear();
            filePaths.Clear();
            mainSplitContainer.Visible = false;
            clearToolStripButton.Enabled = false;
        }

        private void OnWriteToConsole(string text)
        {
            consoleTextBox.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text + Environment.NewLine );
            Application.DoEvents();
        }

        #endregion

        #region Menu event methods

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projectOnCodePlexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.codeplex.com/DependencyFinder");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigureDependencyVisualizer().ShowDialog(this);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((projectsListBox.SelectedItem as Project).Path);
        }

        private void visualizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DependencyGraphVisualizer viz = new DependencyGraphVisualizer();
                viz.Visualize((projectsListBox.SelectedItem as Project).Path);

                new VisualizationViewer((projectsListBox.SelectedItem as Project).Name).ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Visualization error");
            }
        }
       
        #endregion

        #region BackgroundWork methods

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Fill up the filePaths list
            GetProjectFiles(Properties.Settings.Default.RootPath);

            //ToDo: Needs attention! Progressbar doesn't work properly
            if (filePaths.Count > 0)
            {
                float valueToAdd = 100 / filePaths.Count;
                float percentProgress = 0;
                
                foreach (string projectFile in filePaths)
                {
                    percentProgress += valueToAdd;
                    dateCollecterBackgroundWorker.ReportProgress((int)percentProgress);
                    try
                    {
                        ProjectRepository.Instance.Add(projectFile);
                    }
                    catch (Exception ex)
                    {
                        if (InvokeRequired)
                            Invoke(new WriteToConsole(OnWriteToConsole), ex.Message + "(" + projectFile +")");
                    }

                    //Check if the user has cancelled the process
                    if (dateCollecterBackgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Collecting error");
            }
            else if (e.Cancelled)
            {
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Cancelled";
                cancelToolStripButton.Enabled = false;
                mainSplitContainer.Visible = false;
                clearToolStripButton.Enabled = false;
                startCollectDataToolStripButton.Enabled = true;
                //Clear the list
                clearToolStripButton_Click(null, null);
            }
            else
            {
                projectsListBox.DataSource = ProjectRepository.Instance.ProjectList;
                assemblyProjectListBox.DataSource = ProjectRepository.Instance.AssemblyProjectList;
                projectsListBox.DataSource = ProjectRepository.Instance.ProjectList;

                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Finished";

                mainSplitContainer.Visible = true;
                cancelToolStripButton.Enabled = false;
                clearToolStripButton.Enabled = true;
                startCollectDataToolStripButton.Enabled = true;
            }

            //Set this to false, so we can take collect again
            progressCancelled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        } 

        #endregion

       
    }
}
