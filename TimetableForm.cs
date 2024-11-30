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
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
            LoadTimetable();

        }

        private void LoadTimetable()
        {
            dataGridViewTimetable.Rows.Add("Monday", "Math 101");
            dataGridViewTimetable.Rows.Add("Tuesday", "Physics 202");

        }

        private void TimetableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShowMainForm();
        }
    }
}
