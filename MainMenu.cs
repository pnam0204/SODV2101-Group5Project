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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Global.centerControl(title, panel1);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            new CourseInformationForm().Show();
            Global.HideMainForm();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            new EnrollmentForm().Show();
            Global.HideMainForm();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            new TimetableForm().Show();
            Global.HideMainForm();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            new NotificationsForm().Show();
            Global.HideMainForm();
        }

        private void btnMessaging_Click(object sender, EventArgs e)
        {
            new MessagingForm().Show();
            Global.HideMainForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.ShowLoginForm();
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            Global.centerControl(title, panel1);
        }
    }

}

