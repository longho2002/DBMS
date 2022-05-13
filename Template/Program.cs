using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Form1 flogin = new Form1();
            //flogin.ShowDialog();
            //if (flogin.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new MainForm());
            //}
            Application.Run(new MainForm());
        }
    }
}
