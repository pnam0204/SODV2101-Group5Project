using System;

namespace Group5Project
{
    partial class EnrollmentForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(472, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.BackColor = System.Drawing.Color.IndianRed;
            this.EnrollBtn.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollBtn.Location = new System.Drawing.Point(294, 302);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(201, 63);
            this.EnrollBtn.TabIndex = 1;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = false;
            this.EnrollBtn.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(359, 97);
            this.title.TabIndex = 11;
            this.title.Text = "Study Anywhere and Everywhere";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.title);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "EnrollmentForm";
            this.Text = "Enrollment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enrollment_Form_FormClosed);
            this.Resize += new System.EventHandler(this.EnrollmentForm_Resize);
            this.ResumeLayout(false);

        }

        private void Enrollment_Form_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.Label title;
    }
}