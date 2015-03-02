using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DependencyFinder.Forms;

namespace DependencyFinder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Test of checkin
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
