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
        private List<Timetable> Timetable;
        public TimetableForm()
        {
            InitializeComponent();
            
            dataGridViewTimetable.AutoGenerateColumns = false;
            Timetable = new List<Timetable>();
            FillTimetable();
            LoadTimetable();
            Program.centerControl(title);
        }
        private void LoadTimetable()
        {
            dataGridViewTimetable.DataSource = null;
            dataGridViewTimetable.DataSource = Timetable;
        }
        private void TimetableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ShowMainForm();
        }
        private void FillTimetable()
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            //var timetable = new List<TimetableEntry>();
            foreach (var day in daysOfWeek)
            {
                // Filter courses by day and check current user is enrolled
                var coursesToday = Courses.List
                    .Where(course => course.Day.IndexOf(day, StringComparison.OrdinalIgnoreCase) >= 0
                    && course.StudentList.Contains(ThisLogin.Username))
                    .ToList();

                if (coursesToday.Any()) // If there are any courses for this day
                {
                    // Concatenate course names into a single string
                    var courseNames = string.Join(", ", coursesToday.Select(course => course.CourseName));

                    // Add a TimetableEntry for this day with the concatenated course names
                    Timetable.Add(new Timetable
                    {
                        Day = day,
                        CourseName = courseNames
                    });
                }
            }
        }

        private void TimetableForm_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title);
        }
    }
}
