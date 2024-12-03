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
        string username, password;
        public Login()
        {
            InitializeComponent();
            Global.LoadCSV(@"UserList.csv", Global.UserList, input => new User(input));
            Global.centerControl(title, panel1, label3);
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
                Global.currentUser = new User(username, password);
                MessageBox.Show("login successful");
                ClearText();

                Global.mainForm = new MainMenu();
                Global.mainForm.Show();
                Global.HideLoginForm();
            }
            else
            {
                label3.Text = "Incorrect username or password";
                textBox2.Text = "";
            }
        }
        private bool VerifyLogin(string username, string password)
        {
            var list = Global.UserList;
            foreach (var e in list)
            {
                if (e.Username == username && e.Password == password) return true;
            }
            return false;
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            Global.centerControl(title, panel1, label3);
        }

        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label3.Text = "Please enter username and password";
        }
    }
}