namespace DependencyFinder.Forms
{
    partial class VisualizationViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizationViewer));
            this.diagramPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagramPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramPictureBox
            // 
            this.diagramPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramPictureBox.Location = new System.Drawing.Point(0, 0);
            this.diagramPictureBox.Name = "diagramPictureBox";
            this.diagramPictureBox.Size = new System.Drawing.Size(650, 509);
            this.diagramPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diagramPictureBox.TabIndex = 0;
            this.diagramPictureBox.TabStop = false;
            // 
            // VisualizationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 509);
            this.Controls.Add(this.diagramPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizationViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VisualizationViewer";
            ((System.ComponentModel.ISupportInitialize)(this.diagramPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox diagramPictureBox;
    }
}