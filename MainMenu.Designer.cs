namespace Group5Project
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseInformation = new System.Windows.Forms.Button();
            this.Enrollment = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.Button();
            this.Noifications = new System.Windows.Forms.Button();
            this.Messaging = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseInformation
            // 
            this.CourseInformation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CourseInformation.Location = new System.Drawing.Point(3, 3);
            this.CourseInformation.Name = "CourseInformation";
            this.CourseInformation.Size = new System.Drawing.Size(169, 82);
            this.CourseInformation.TabIndex = 1;
            this.CourseInformation.Text = "Course";
            this.CourseInformation.UseVisualStyleBackColor = false;
            this.CourseInformation.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // Enrollment
            // 
            this.Enrollment.BackColor = System.Drawing.Color.MediumPurple;
            this.Enrollment.Location = new System.Drawing.Point(3, 91);
            this.Enrollment.Name = "Enrollment";
            this.Enrollment.Size = new System.Drawing.Size(169, 88);
            this.Enrollment.TabIndex = 2;
            this.Enrollment.Text = "Enrollment";
            this.Enrollment.UseVisualStyleBackColor = false;
            this.Enrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // Timetable
            // 
            this.Timetable.BackColor = System.Drawing.Color.Magenta;
            this.Timetable.Location = new System.Drawing.Point(0, 185);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(169, 105);
            this.Timetable.TabIndex = 3;
            this.Timetable.Text = "TimeTable";
            this.Timetable.UseVisualStyleBackColor = false;
            this.Timetable.Click += new System.EventHandler(this.btnTimeTable_Click);
            // 
            // Noifications
            // 
            this.Noifications.BackColor = System.Drawing.Color.Aquamarine;
            this.Noifications.Location = new System.Drawing.Point(328, 34);
            this.Noifications.Name = "Noifications";
            this.Noifications.Size = new System.Drawing.Size(194, 92);
            this.Noifications.TabIndex = 4;
            this.Noifications.Text = "Notifications";
            this.Noifications.UseVisualStyleBackColor = false;
            this.Noifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // Messaging
            // 
            this.Messaging.BackColor = System.Drawing.Color.Crimson;
            this.Messaging.Location = new System.Drawing.Point(328, 156);
            this.Messaging.Name = "Messaging";
            this.Messaging.Size = new System.Drawing.Size(194, 99);
            this.Messaging.TabIndex = 5;
            this.Messaging.Text = "Messaging";
            this.Messaging.UseVisualStyleBackColor = false;
            this.Messaging.Click += new System.EventHandler(this.btnMessaging_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(197, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(359, 97);
            this.title.TabIndex = 12;
            this.title.Text = "Study Anywhere and Everywhere";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CourseInformation);
            this.panel1.Controls.Add(this.Enrollment);
            this.panel1.Controls.Add(this.Messaging);
            this.panel1.Controls.Add(this.Timetable);
            this.panel1.Controls.Add(this.Noifications);
            this.panel1.Location = new System.Drawing.Point(107, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 295);
            this.panel1.TabIndex = 13;
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(780, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CourseInformation;
        private System.Windows.Forms.Button Enrollment;
        private System.Windows.Forms.Button Timetable;
        private System.Windows.Forms.Button Noifications;
        private System.Windows.Forms.Button Messaging;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
    }
}