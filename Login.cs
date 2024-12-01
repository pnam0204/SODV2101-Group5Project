using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{

    public partial class Login : Form
    {
        string[] userArray = { "user", "admin", "student", "teacher"};
        string passCheck = "password";
        string username, password;
        public Login()
        {
            InitializeComponent();
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

                Program.mainForm = new MainForm();
                Program.mainForm.Show();
                Program.HideLoginForm();
            }
            else
            {
                textBox3.Text = "Incorrect username or password";
                textBox2.Text = "";
            }
        }
        private bool VerifyLogin(string username, string password)
        {
            if (userArray.Contains(username) && password == passCheck)
            {
                return true;
            }
            else return false;
        }
        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = "Please enter username and password";
        }
    }
}