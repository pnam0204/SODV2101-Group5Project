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
            if (textBox1.Text == "username" && textBox2.Text == "password")
            {
                MessageBox.Show("login successful");
                new MainForm().Show();
                ClearText();
            }
            else
            {
                textBox3.Text = "Incorrect username or password";
                textBox2.Text = "";
            }
        }
        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = "Please enter username and password";
        }
    }
}

     
