using System;

namespace Group5Project
{
    partial class Enrollment_Form
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
            this.Enroll = new System.Windows.Forms.Button();
            this.title4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(472, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Enroll
            // 
            this.Enroll.BackColor = System.Drawing.Color.IndianRed;
            this.Enroll.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enroll.Location = new System.Drawing.Point(167, 308);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(201, 63);
            this.Enroll.TabIndex = 1;
            this.Enroll.Text = "Enroll";
            this.Enroll.UseVisualStyleBackColor = false;
            this.Enroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // title4
            // 
            this.title4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title4.Location = new System.Drawing.Point(45, 55);
            this.title4.Name = "title4";
            this.title4.Size = new System.Drawing.Size(412, 68);
            this.title4.TabIndex = 2;
            this.title4.Text = "Study Anywhere and Everywhere";
            this.title4.UseVisualStyleBackColor = true;
            // 
            // Enrollment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.title4);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.comboBox1);
            this.Name = "Enrollment_Form";
            this.Text = "Enrollment_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enrollment_Form_FormClosed);
            this.ResumeLayout(false);

        }

        private void Enrollment_Form_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button title4;
    }
}