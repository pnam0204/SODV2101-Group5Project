namespace Group5Project
{
    partial class CourseInformationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.Descrption,
            this.Timings});
            this.dataGridView1.Location = new System.Drawing.Point(36, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 125;
            // 
            // Descrption
            // 
            this.Descrption.HeaderText = "Descrption";
            this.Descrption.MinimumWidth = 6;
            this.Descrption.Name = "Descrption";
            this.Descrption.Width = 125;
            // 
            // Timings
            // 
            this.Timings.HeaderText = "Timgings";
            this.Timings.MinimumWidth = 6;
            this.Timings.Name = "Timings";
            this.Timings.Width = 125;
            // 
            // title3
            // 
            this.title3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.Location = new System.Drawing.Point(45, 32);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(371, 98);
            this.title3.TabIndex = 1;
            this.title3.Text = "Study Anywhere and Everywhere";
            this.title3.UseVisualStyleBackColor = true;
            // 
            // CourseInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(508, 470);
            this.Controls.Add(this.title3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CourseInformationForm";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseInformationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timings;
        private System.Windows.Forms.Button title3;
    }
}