namespace Group5Project
{
    partial class MainForm
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
            this.title2 = new System.Windows.Forms.Button();
            this.CourseForm = new System.Windows.Forms.Button();
            this.Enrollment = new System.Windows.Forms.Button();
            this.timetable = new System.Windows.Forms.Button();
            this.Noifications = new System.Windows.Forms.Button();
            this.Messaging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.Location = new System.Drawing.Point(49, 21);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(543, 102);
            this.title2.TabIndex = 0;
            this.title2.Text = "Study Anywhere and Everywhere";
            this.title2.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.CourseForm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CourseForm.Location = new System.Drawing.Point(30, 144);
            this.CourseForm.Name = "CourseForm";
            this.CourseForm.Size = new System.Drawing.Size(169, 82);
            this.CourseForm.TabIndex = 1;
            this.CourseForm.Text = "Course";
            this.CourseForm.UseVisualStyleBackColor = false;
            this.CourseForm.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // Enrollment
            // 
            this.Enrollment.BackColor = System.Drawing.Color.MediumPurple;
            this.Enrollment.Location = new System.Drawing.Point(30, 232);
            this.Enrollment.Name = "Enrollment";
            this.Enrollment.Size = new System.Drawing.Size(169, 88);
            this.Enrollment.TabIndex = 2;
            this.Enrollment.Text = "Enrollment";
            this.Enrollment.UseVisualStyleBackColor = false;
            this.Enrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // timetable
            // 
            this.timetable.BackColor = System.Drawing.Color.Magenta;
            this.timetable.Location = new System.Drawing.Point(30, 326);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(169, 105);
            this.timetable.TabIndex = 3;
            this.timetable.Text = "TimeTable";
            this.timetable.UseVisualStyleBackColor = false;
            this.timetable.Click += new System.EventHandler(this.btnTimeTable_Click);
            // 
            // Noifications
            // 
            this.Noifications.BackColor = System.Drawing.Color.Aquamarine;
            this.Noifications.Location = new System.Drawing.Point(426, 169);
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
            this.Messaging.Location = new System.Drawing.Point(426, 288);
            this.Messaging.Name = "Messaging";
            this.Messaging.Size = new System.Drawing.Size(194, 99);
            this.Messaging.TabIndex = 5;
            this.Messaging.Text = "Messaging";
            this.Messaging.UseVisualStyleBackColor = false;
            this.Messaging.Click += new System.EventHandler(this.btnMessaging_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(665, 464);
            this.Controls.Add(this.Messaging);
            this.Controls.Add(this.Noifications);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.Enrollment);
            this.Controls.Add(this.CourseForm);
            this.Controls.Add(this.title2);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Title;
        private System.Windows.Forms.Button courses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button notifications;
        private System.Windows.Forms.Button title2;
        private System.Windows.Forms.Button CourseForm;
        private System.Windows.Forms.Button Enrollment;
        private System.Windows.Forms.Button timetable;
        private System.Windows.Forms.Button Noifications;
        private System.Windows.Forms.Button Messaging;
    }
}