using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using NewUI;
using OldUI;

namespace PGPFileTool
{
    static class Program
    {
        public static bool NewDesign = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MessageBox.Show("Include new design?", "UI Design", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Run(new MainForm()); 
                NewDesign = true;
            }
            else
            {
                Application.Run(new OldMainForm());
            }
        }
    }
}
