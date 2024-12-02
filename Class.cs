using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Group5Project
{
    static class Forms
    {
        public static Login loginForm;
        public static MainMenu mainForm;
        public static void ShowLoginForm()
        {
            loginForm.Show();
        }
        public static void HideLoginForm()
        {
            loginForm.Hide();
        }
        public static void ShowMainForm()
        {
            mainForm.Show();
        }
        public static void HideMainForm()
        {
            mainForm.Hide();
        }
    }
    static class Courses
    {
        public static List<CourseInfo> List = new List<CourseInfo>();
        public static void LoadCSV()
        {
            string filePath = @"..\..\CourseInformation.csv";
            try
            {
                using (var reader = File.OpenText(filePath))
                {
                    string input = reader.ReadLine();
                    while ((input = reader.ReadLine()) != null)
                    {
                        CourseInfo course = new CourseInfo(input);
                        List.Add(course);
                    }
                }
                MessageBox.Show("Data Loaded Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
        }
    }
    static class ThisLogin
    {
        public static string Username { get; set; }
    }
    static class Storage
    {
        public static List<Conversation> Conversations = new List<Conversation>();
    }
    public class Conversation
    {
        //public static Dictionary<string, List<string>> Conversations = new Dictionary<string, List<string>>();
        public string Sender { get; set; }
        public string Receiver {  get; set; }
        public List<string> Contents { get; set; }
        public Conversation(string sender, string receiver)
        {
            Sender = sender;
            Receiver = receiver;
            Contents = new List<string>();
        }
    }
    public class Timetable
    {
        public string Day { get; set; }
        public string CourseName { get; set; } // Comma-separated list of courses for the day
    }
    public class CourseInfo
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public List<string> StudentList = new List<string>();

        private string NextValue(string csv, ref int index)
        {
            string result = "";
            if (index >= csv.Length) return result; // End of string reached
            // Skip leading comma
            if (csv[index] == ',')
            {
                index++;
                return ""; // Return empty string for consecutive commas
            }
            // Handle quoted fields
            if (csv[index] == '"')
            {
                int startIndex = index + 1; // Skip opening quote
                int endIndex = csv.IndexOf('"', startIndex);
                if (endIndex == -1) throw new FormatException("Unmatched quotes in CSV");
                result = csv.Substring(startIndex, endIndex - startIndex);
                index = endIndex + 1; // Move past closing quote
                // Skip trailing comma
                if (index < csv.Length && csv[index] == ',') index++;
                return result.Trim();
            }
            // Handle regular fields
            int commaIndex = csv.IndexOf(',', index);
            if (commaIndex == -1)
            {
                result = csv.Substring(index).Trim(); // Last field
                index = csv.Length;
            }
            else
            {
                result = csv.Substring(index, commaIndex - index).Trim();
                index = commaIndex + 1; // Move past the comma
            }
            return result;
        }
        public CourseInfo(string csv)
        {
            int index = 0;
            try
            {
                CourseName = NextValue(csv, ref index);
                Description = NextValue(csv, ref index);
                Day = NextValue(csv, ref index);
                Time = NextValue(csv, ref index);
                string student = NextValue(csv, ref index);
                while (!string.IsNullOrWhiteSpace(student)) // Stop on empty or null strings
                {
                    StudentList.Add(student);
                    student = NextValue(csv, ref index);
                }
            }
            catch (Exception ex)
            {
                throw new FormatException($"Error parsing CSV line: {csv}", ex);
            }
            
        }
    }
}
