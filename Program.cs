using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group5Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Courses.LoadCSV();
            Forms.loginForm = new Login();
            Application.Run(Forms.loginForm);
        }
        public static void centerControl(params Control[] e)
        {
            foreach (Control c in e)
            {
                c.Left = (c.Parent.ClientSize.Width - c.Width) / 2;
            }
        }
    }
}
