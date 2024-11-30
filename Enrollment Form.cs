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
    public partial class Enrollment_Form : Form
    {
        public Enrollment_Form()
        {
            InitializeComponent();
            LoadCourses();

        }

        private void LoadCourses()
        {
            comboBox1.Items.Add("Math 101");
            comboBox1.Items.Add("Physics 202");
            
        }
       

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have enrolled in {comboBox1.SelectedItem}");

        }

        private void Enrollment_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShowMainForm();
        }
    }
}
