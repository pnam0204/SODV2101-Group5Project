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
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            Program.centerControl(title, comboBox1, EnrollBtn);
            LoadCourses();
        }
        private void LoadCourses()
        {
            foreach (var courses in Courses.List)
            {
                comboBox1.Items.Add(courses.CourseName);
            }
        }
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string selectedCourseName = comboBox1.SelectedItem.ToString();
            var selectedCourse = Courses.List
                .First(course => course.CourseName == selectedCourseName);
            if (selectedCourse != null)
            {
                if (!selectedCourse.StudentList.Contains(ThisLogin.Username))
                {
                    selectedCourse.StudentList.Add(ThisLogin.Username);
                    MessageBox.Show($"You have successfully enrolled in {selectedCourseName}.");
                }
                else MessageBox.Show($"You are already enrolled in {selectedCourseName}!");
            }
            else MessageBox.Show("Course not found.");
        }
        private void Enrollment_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ShowMainForm();
        }

        private void EnrollmentForm_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title, comboBox1, EnrollBtn);
        }
    }
}
