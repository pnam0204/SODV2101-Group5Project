using System;

namespace Group5Project
{
    partial class MessagingForm
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
            this.title8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title8
            // 
            this.title8.Location = new System.Drawing.Point(120, 45);
            this.title8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.title8.Name = "title8";
            this.title8.Size = new System.Drawing.Size(301, 67);
            this.title8.TabIndex = 0;
            this.title8.Text = "Study Anywhere and Everywhere";
            this.title8.UseVisualStyleBackColor = true;
            // 
            // MessagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 487);
            this.Controls.Add(this.title8);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MessagingForm";
            this.Text = "MessagingForm";
            this.ResumeLayout(false);

        }

        private void MessagingForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button title8;
    }
}