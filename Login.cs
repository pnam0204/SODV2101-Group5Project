using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{

    public partial class Login : Form
    {
        string[] userArray = { "user", "admin", "student", "teacher", "p.pham746"};
        string[] passArray = { "password", "0000", "453746" };
        string username, password;
        public Login()
        {
            InitializeComponent();
            Program.centerControl(title, panel1, label3);
        }

        private void Login_Cancel(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            if (VerifyLogin(username, password))
            {
                ThisLogin.Username = username;
                MessageBox.Show("login successful");
                ClearText();

                Forms.mainForm = new MainMenu();
                Forms.mainForm.Show();
                Forms.HideLoginForm();
            }
            else
            {
                label3.Text = "Incorrect username or password";
                textBox2.Text = "";
            }
        }
        private bool VerifyLogin(string username, string password)
        {
            if (userArray.Contains(username) && passArray.Contains(password))
            {
                return true;
            }
            else return false;
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title, panel1, label3);
        }

        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label3.Text = "Please enter username and password";
        }
    }
}