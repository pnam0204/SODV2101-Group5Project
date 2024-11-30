using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            new CourseInformationForm().Show();
            Program.HideMainForm();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            new Enrollment_Form().Show();
            Program.HideMainForm();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            new TimetableForm().Show();
            Program.HideMainForm();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            new NotificationsForm().Show();
            Program.HideMainForm();
        }

        private void btnMessaging_Click(object sender, EventArgs e)
        {
            new MessagingForm().Show();
            Program.HideMainForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShowLoginForm();
        }
    }

}

