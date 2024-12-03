using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace Group5Project
{
    static class Global
    {
        public static List<CourseInfo> CourseList = new List<CourseInfo>();
        public static List<User> UserList = new List<User>();
        public static User currentUser = new User();
        public static List<Conversation> PastConversations = new List<Conversation>();

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
        public static void centerControl(params Control[] e)
        {
            foreach (Control c in e)
            {
                c.Left = (c.Parent.ClientSize.Width - c.Width) / 2;
            }
        }
        public static string NextValue(string csv, ref int index)
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
        public static void LoadCSV<T>(string filePath, List<T> list, Func<string, T> createObject)
        {
            try
            {
                using (var reader = File.OpenText(filePath))
                {
                    string input = reader.ReadLine();
                    while ((input = reader.ReadLine()) != null)
                    {
                        T obj = createObject(input);
                        list.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User (string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User (string csv)
        {
            int index = 0;
            Username = Global.NextValue(csv, ref index);
            Password = Global.NextValue(csv, ref index);
        }
    }
    public class Conversation
    {
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

        public CourseInfo(string csv)
        {
            int index = 0;
            try
            {
                CourseName = Global.NextValue(csv, ref index);
                Description = Global.NextValue(csv, ref index);
                Day = Global.NextValue(csv, ref index);
                Time = Global.NextValue(csv, ref index);
                string student = Global.NextValue(csv, ref index);
                while (!string.IsNullOrWhiteSpace(student)) // Stop on empty or null strings
                {
                    StudentList.Add(student);
                    student = Global.NextValue(csv, ref index);
                }
            }
            catch (Exception ex)
            {
                throw new FormatException($"Error parsing CSV line: {csv}", ex);
            }
            
        }
    }
}
