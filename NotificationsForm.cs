using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{
    public partial class NotificationsForm : Form
    {
        public NotificationsForm()
        {
            InitializeComponent();
            Program.centerControl(title, listBox1);
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            listBox1.Items.Add("Math Assignment due on 20th Nov");
            listBox1.Items.Add("Physics Lab on 21st Nov");
        }

        private void NotificationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ShowMainForm();
        }

        private void NotificationsForm_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title, listBox1);
        }
    }
}
