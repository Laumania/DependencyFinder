using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DependencyVisualizer {
    /// <summary>
    /// Configuration UI for Dependency Visualizer
    /// </summary>
    public partial class ConfigureDependencyVisualizer : Form {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureDependencyVisualizer"/> class.
        /// </summary>
        public ConfigureDependencyVisualizer() {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}