namespace Group5Project
{
    partial class TimetableForm
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
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.title6 = new System.Windows.Forms.Button();
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(2, 147);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // title6
            // 
            this.title6.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title6.Location = new System.Drawing.Point(122, 37);
            this.title6.Name = "title6";
            this.title6.Size = new System.Drawing.Size(351, 71);
            this.title6.TabIndex = 1;
            this.title6.Text = "Study Anywhere and Everywhere";
            this.title6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Course});
            this.dataGridViewTimetable.Location = new System.Drawing.Point(261, 147);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.RowHeadersWidth = 51;
            this.dataGridViewTimetable.RowTemplate.Height = 24;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(336, 207);
            this.dataGridViewTimetable.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.HeaderText = "Day";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.Width = 125;
            // 
            // TimetableForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(599, 397);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Controls.Add(this.title6);
            this.Controls.Add(this.monthCalendar2);
            this.Name = "TimetableForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimetableForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button title6;
        private System.Windows.Forms.DataGridView dataGridViewTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}