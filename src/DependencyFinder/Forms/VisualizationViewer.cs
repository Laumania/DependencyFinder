using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DependencyFinder.Forms
{
    public partial class VisualizationViewer : Form
    {
        private Image diagram;

        public VisualizationViewer(string projectName)
        {
            InitializeComponent();
            diagram = Image.FromFile(@"Dependencies\" + projectName.Replace(" - Copy","") + ".png");
            diagramPictureBox.Image = diagram;
        }
    }
}
