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
    public partial class CourseInformationForm : Form
    {
        public CourseInformationForm()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses()
        {
            dataGridView1.Rows.Add("Math 101", "Basic Algebra", "MWF 10:00 - 11:00");
            dataGridView1.Rows.Add("Physics 202", "Mechanics", "TTh 2:00-3:30");

         }

        
    }
}
