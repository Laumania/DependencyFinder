namespace DependencyFinder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.projectPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.rootPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.versionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateCollecterBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectOnCodePlexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectPathLabel = new System.Windows.Forms.Label();
            this.projectCaptionLabel = new System.Windows.Forms.Label();
            this.referenceProjectsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.referencesListBox = new System.Windows.Forms.ListBox();
            this.projectReferencesListBox = new System.Windows.Forms.ListBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.explorerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.projectsTabControl = new System.Windows.Forms.TabControl();
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.projectContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyProjectsTabPage = new System.Windows.Forms.TabPage();
            this.assemblyProjectListBox = new System.Windows.Forms.ListBox();
            this.projectTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startCollectDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rootPathToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.browseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.explorerSplitContainer.Panel1.SuspendLayout();
            this.explorerSplitContainer.Panel2.SuspendLayout();
            this.explorerSplitContainer.SuspendLayout();
            this.projectsTabControl.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            this.projectContextMenuStrip.SuspendLayout();
            this.assemblyProjectsTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectPropertyGrid
            // 
            this.projectPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.projectPropertyGrid.Name = "projectPropertyGrid";
            this.projectPropertyGrid.Size = new System.Drawing.Size(245, 289);
            this.projectPropertyGrid.TabIndex = 2;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.versionToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 644);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(890, 22);
            this.mainStatusStrip.TabIndex = 10;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 15;
            this.toolStripProgressBar1.Visible = false;
            // 
            // versionToolStripStatusLabel
            // 
            this.versionToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionToolStripStatusLabel.Name = "versionToolStripStatusLabel";
            this.versionToolStripStatusLabel.Size = new System.Drawing.Size(837, 17);
            this.versionToolStripStatusLabel.Spring = true;
            this.versionToolStripStatusLabel.Text = "v0.0.0.0";
            this.versionToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateCollecterBackgroundWorker
            // 
            this.dateCollecterBackgroundWorker.WorkerReportsProgress = true;
            this.dateCollecterBackgroundWorker.WorkerSupportsCancellation = true;
            this.dateCollecterBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.dateCollecterBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.dateCollecterBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectOnCodePlexToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // projectOnCodePlexToolStripMenuItem
            // 
            this.projectOnCodePlexToolStripMenuItem.Name = "projectOnCodePlexToolStripMenuItem";
            this.projectOnCodePlexToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.projectOnCodePlexToolStripMenuItem.Text = "Project on &CodePlex";
            this.projectOnCodePlexToolStripMenuItem.Click += new System.EventHandler(this.projectOnCodePlexToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 52);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.contentSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.explorerSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(890, 589);
            this.mainSplitContainer.SplitterDistance = 639;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 19;
            this.mainSplitContainer.Visible = false;
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "contentSplitContainer";
            this.contentSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.pictureBox2);
            this.contentSplitContainer.Panel1.Controls.Add(this.pictureBox1);
            this.contentSplitContainer.Panel1.Controls.Add(this.projectPathLabel);
            this.contentSplitContainer.Panel1.Controls.Add(this.projectCaptionLabel);
            this.contentSplitContainer.Panel1.Controls.Add(this.referenceProjectsListBox);
            this.contentSplitContainer.Panel1.Controls.Add(this.label3);
            this.contentSplitContainer.Panel1.Controls.Add(this.label2);
            this.contentSplitContainer.Panel1.Controls.Add(this.label1);
            this.contentSplitContainer.Panel1.Controls.Add(this.referencesListBox);
            this.contentSplitContainer.Panel1.Controls.Add(this.projectReferencesListBox);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.consoleTextBox);
            this.contentSplitContainer.Size = new System.Drawing.Size(639, 589);
            this.contentSplitContainer.SplitterDistance = 455;
            this.contentSplitContainer.SplitterWidth = 2;
            this.contentSplitContainer.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // projectPathLabel
            // 
            this.projectPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectPathLabel.AutoSize = true;
            this.projectPathLabel.Location = new System.Drawing.Point(10, 29);
            this.projectPathLabel.Name = "projectPathLabel";
            this.projectPathLabel.Size = new System.Drawing.Size(67, 13);
            this.projectPathLabel.TabIndex = 26;
            this.projectPathLabel.Text = "Project path:";
            // 
            // projectCaptionLabel
            // 
            this.projectCaptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectCaptionLabel.AutoSize = true;
            this.projectCaptionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCaptionLabel.Location = new System.Drawing.Point(10, 4);
            this.projectCaptionLabel.Name = "projectCaptionLabel";
            this.projectCaptionLabel.Size = new System.Drawing.Size(78, 18);
            this.projectCaptionLabel.TabIndex = 25;
            this.projectCaptionLabel.Text = "Project:";
            // 
            // referenceProjectsListBox
            // 
            this.referenceProjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.referenceProjectsListBox.FormattingEnabled = true;
            this.referenceProjectsListBox.Location = new System.Drawing.Point(10, 65);
            this.referenceProjectsListBox.Name = "referenceProjectsListBox";
            this.referenceProjectsListBox.Size = new System.Drawing.Size(622, 82);
            this.referenceProjectsListBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Project References";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "The following projects have a reference to the current Project/AssemblyProject:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "References";
            // 
            // referencesListBox
            // 
            this.referencesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.referencesListBox.FormattingEnabled = true;
            this.referencesListBox.Location = new System.Drawing.Point(10, 171);
            this.referencesListBox.Name = "referencesListBox";
            this.referencesListBox.Size = new System.Drawing.Size(622, 82);
            this.referencesListBox.TabIndex = 21;
            this.referencesListBox.Click += new System.EventHandler(this.assemblyProjectReferencesListBox_Click);
            // 
            // projectReferencesListBox
            // 
            this.projectReferencesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectReferencesListBox.FormattingEnabled = true;
            this.projectReferencesListBox.Location = new System.Drawing.Point(10, 278);
            this.projectReferencesListBox.Name = "projectReferencesListBox";
            this.projectReferencesListBox.Size = new System.Drawing.Size(622, 95);
            this.projectReferencesListBox.TabIndex = 22;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(635, 128);
            this.consoleTextBox.TabIndex = 0;
            this.consoleTextBox.TabStop = false;
            this.consoleTextBox.WordWrap = false;
            // 
            // explorerSplitContainer
            // 
            this.explorerSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.explorerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.explorerSplitContainer.Name = "explorerSplitContainer";
            this.explorerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // explorerSplitContainer.Panel1
            // 
            this.explorerSplitContainer.Panel1.Controls.Add(this.projectsTabControl);
            // 
            // explorerSplitContainer.Panel2
            // 
            this.explorerSplitContainer.Panel2.Controls.Add(this.projectPropertyGrid);
            this.explorerSplitContainer.Size = new System.Drawing.Size(249, 589);
            this.explorerSplitContainer.SplitterDistance = 294;
            this.explorerSplitContainer.SplitterWidth = 2;
            this.explorerSplitContainer.TabIndex = 3;
            // 
            // projectsTabControl
            // 
            this.projectsTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.projectsTabControl.Controls.Add(this.projectsTabPage);
            this.projectsTabControl.Controls.Add(this.assemblyProjectsTabPage);
            this.projectsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsTabControl.ImageList = this.projectTypeImageList;
            this.projectsTabControl.Location = new System.Drawing.Point(0, 0);
            this.projectsTabControl.Name = "projectsTabControl";
            this.projectsTabControl.SelectedIndex = 0;
            this.projectsTabControl.Size = new System.Drawing.Size(245, 290);
            this.projectsTabControl.TabIndex = 0;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.Controls.Add(this.projectsListBox);
            this.projectsTabPage.ImageIndex = 1;
            this.projectsTabPage.Location = new System.Drawing.Point(4, 4);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(237, 263);
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "Projects";
            this.projectsTabPage.UseVisualStyleBackColor = true;
            // 
            // projectsListBox
            // 
            this.projectsListBox.ContextMenuStrip = this.projectContextMenuStrip;
            this.projectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.Location = new System.Drawing.Point(3, 3);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(231, 251);
            this.projectsListBox.TabIndex = 4;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projects_SelectedIndexChanged);
            // 
            // projectContextMenuStrip
            // 
            this.projectContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.visualizeToolStripMenuItem});
            this.projectContextMenuStrip.Name = "projectContextMenuStrip";
            this.projectContextMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // visualizeToolStripMenuItem
            // 
            this.visualizeToolStripMenuItem.Name = "visualizeToolStripMenuItem";
            this.visualizeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.visualizeToolStripMenuItem.Text = "Visualize";
            this.visualizeToolStripMenuItem.Click += new System.EventHandler(this.visualizeToolStripMenuItem_Click);
            // 
            // assemblyProjectsTabPage
            // 
            this.assemblyProjectsTabPage.Controls.Add(this.assemblyProjectListBox);
            this.assemblyProjectsTabPage.ImageIndex = 0;
            this.assemblyProjectsTabPage.Location = new System.Drawing.Point(4, 4);
            this.assemblyProjectsTabPage.Name = "assemblyProjectsTabPage";
            this.assemblyProjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assemblyProjectsTabPage.Size = new System.Drawing.Size(233, 261);
            this.assemblyProjectsTabPage.TabIndex = 1;
            this.assemblyProjectsTabPage.Text = "Assemblies";
            this.assemblyProjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // assemblyProjectListBox
            // 
            this.assemblyProjectListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assemblyProjectListBox.FormattingEnabled = true;
            this.assemblyProjectListBox.Location = new System.Drawing.Point(3, 3);
            this.assemblyProjectListBox.Name = "assemblyProjectListBox";
            this.assemblyProjectListBox.Size = new System.Drawing.Size(227, 251);
            this.assemblyProjectListBox.TabIndex = 16;
            this.assemblyProjectListBox.SelectedIndexChanged += new System.EventHandler(this.assemblyProjects_SelectedIndexChanged);
            // 
            // projectTypeImageList
            // 
            this.projectTypeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("projectTypeImageList.ImageStream")));
            this.projectTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.projectTypeImageList.Images.SetKeyName(0, "assemblyProject.png");
            this.projectTypeImageList.Images.SetKeyName(1, "csprojProject.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startCollectDataToolStripButton,
            this.rootPathToolStripTextBox,
            this.browseToolStripButton,
            this.cancelToolStripButton,
            this.clearToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startCollectDataToolStripButton
            // 
            this.startCollectDataToolStripButton.Image = global::DependencyFinder.Properties.Resources.playPng;
            this.startCollectDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startCollectDataToolStripButton.Name = "startCollectDataToolStripButton";
            this.startCollectDataToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.startCollectDataToolStripButton.Text = "&Start";
            this.startCollectDataToolStripButton.Click += new System.EventHandler(this.collectDateButton_Click);
            // 
            // rootPathToolStripTextBox
            // 
            this.rootPathToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rootPathToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rootPathToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.rootPathToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootPathToolStripTextBox.Name = "rootPathToolStripTextBox";
            this.rootPathToolStripTextBox.Size = new System.Drawing.Size(350, 25);
            // 
            // browseToolStripButton
            // 
            this.browseToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.browseToolStripButton.Image = global::DependencyFinder.Properties.Resources.explorePng;
            this.browseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseToolStripButton.Name = "browseToolStripButton";
            this.browseToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.browseToolStripButton.Text = "&Browse";
            this.browseToolStripButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.Enabled = false;
            this.cancelToolStripButton.Image = global::DependencyFinder.Properties.Resources.stopPng;
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.cancelToolStripButton_Click);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.Enabled = false;
            this.clearToolStripButton.Image = global::DependencyFinder.Properties.Resources.clearList;
            this.clearToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.clearToolStripButton.Text = "Clear";
            this.clearToolStripButton.ToolTipText = "Clear the list of collected Projects and AssemblyProjects";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dependency Finder";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel1.PerformLayout();
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            this.contentSplitContainer.Panel2.PerformLayout();
            this.contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.explorerSplitContainer.Panel1.ResumeLayout(false);
            this.explorerSplitContainer.Panel2.ResumeLayout(false);
            this.explorerSplitContainer.ResumeLayout(false);
            this.projectsTabControl.ResumeLayout(false);
            this.projectsTabPage.ResumeLayout(false);
            this.projectContextMenuStrip.ResumeLayout(false);
            this.assemblyProjectsTabPage.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid projectPropertyGrid;
        private System.Windows.Forms.FolderBrowserDialog rootPathFolderBrowserDialog;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker dateCollecterBackgroundWorker;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer explorerSplitContainer;
        private System.Windows.Forms.TabControl projectsTabControl;
        private System.Windows.Forms.TabPage projectsTabPage;
        private System.Windows.Forms.TabPage assemblyProjectsTabPage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startCollectDataToolStripButton;
        private System.Windows.Forms.ToolStripButton browseToolStripButton;
        private System.Windows.Forms.ToolStripTextBox rootPathToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectOnCodePlexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListBox projectsListBox;
        private System.Windows.Forms.ListBox assemblyProjectListBox;
        private System.Windows.Forms.ImageList projectTypeImageList;
        private System.Windows.Forms.ToolStripStatusLabel versionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton clearToolStripButton;
        private System.Windows.Forms.ContextMenuStrip projectContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem visualizeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label projectPathLabel;
        private System.Windows.Forms.Label projectCaptionLabel;
        private System.Windows.Forms.ListBox referenceProjectsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox referencesListBox;
        private System.Windows.Forms.ListBox projectReferencesListBox;
        private System.Windows.Forms.TextBox consoleTextBox;
    }
}

