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
            this.txtMessageInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lstReceivers = new System.Windows.Forms.ListBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageInput.Location = new System.Drawing.Point(151, 241);
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Size = new System.Drawing.Size(301, 32);
            this.txtMessageInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(458, 241);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 31;
            this.lstMessages.Location = new System.Drawing.Point(152, 3);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(301, 221);
            this.lstMessages.TabIndex = 3;
            // 
            // lstReceivers
            // 
            this.lstReceivers.FormattingEnabled = true;
            this.lstReceivers.ItemHeight = 31;
            this.lstReceivers.Location = new System.Drawing.Point(45, 3);
            this.lstReceivers.Name = "lstReceivers";
            this.lstReceivers.Size = new System.Drawing.Size(101, 221);
            this.lstReceivers.TabIndex = 4;
            this.lstReceivers.SelectedIndexChanged += new System.EventHandler(this.lstReceivers_SelectedIndexChanged);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(46, 241);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(100, 32);
            this.txtReceiver.TabIndex = 5;
            this.txtReceiver.TextChanged += new System.EventHandler(this.txtReceiver_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(210, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(359, 97);
            this.title.TabIndex = 11;
            this.title.Text = "Study Anywhere and Everywhere";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstReceivers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.lstMessages);
            this.panel1.Controls.Add(this.txtMessageInput);
            this.panel1.Controls.Add(this.txtReceiver);
            this.panel1.Location = new System.Drawing.Point(119, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 282);
            this.panel1.TabIndex = 12;
            // 
            // MessagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MessagingForm";
            this.Text = "Message";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessagingForm_FormClosed);
            this.Resize += new System.EventHandler(this.MessagingForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessageInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.ListBox lstReceivers;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
    }
}