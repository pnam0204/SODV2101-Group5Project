using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Login loginForm;
        public static MainForm mainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new Login();
            Application.Run(loginForm);
        }
        public static void ShowLoginForm()
        {
            loginForm.Show();
        }
        public static void HideLoginForm()
        {
            loginForm.Hide();
        }
        public static void ShowMainForm()
        {
            mainForm.Show();
        }
        public static void HideMainForm()
        {
            mainForm.Hide();
        }
    }
}
