using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group5Project
{
    public partial class CourseInformationForm : Form
    {
        public CourseInformationForm()
        {
            InitializeComponent();
            Program.centerControl(title);
            dataGridView1.AutoGenerateColumns = false;
            LoadCourses();
        }
        
        private void LoadCourses()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Courses.List;
        }
        private void CourseInformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ShowMainForm();
        }

        private void CourseInformationForm_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title);
        }
    }
}
