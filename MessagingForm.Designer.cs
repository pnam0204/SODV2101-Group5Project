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
            this.txtMessageInput = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lstReceivers = new System.Windows.Forms.ListBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title8
            // 
            this.title8.Location = new System.Drawing.Point(160, 47);
            this.title8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.title8.Name = "title8";
            this.title8.Size = new System.Drawing.Size(301, 67);
            this.title8.TabIndex = 0;
            this.title8.Text = "Study Anywhere and Everywhere";
            this.title8.UseVisualStyleBackColor = true;
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageInput.Location = new System.Drawing.Point(160, 406);
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Size = new System.Drawing.Size(301, 32);
            this.txtMessageInput.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(467, 406);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 31);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 31;
            this.lstMessages.Location = new System.Drawing.Point(161, 154);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(301, 221);
            this.lstMessages.TabIndex = 3;
            // 
            // lstReceivers
            // 
            this.lstReceivers.FormattingEnabled = true;
            this.lstReceivers.ItemHeight = 31;
            this.lstReceivers.Location = new System.Drawing.Point(54, 154);
            this.lstReceivers.Name = "lstReceivers";
            this.lstReceivers.Size = new System.Drawing.Size(101, 221);
            this.lstReceivers.TabIndex = 4;
            this.lstReceivers.SelectedIndexChanged += new System.EventHandler(this.lstReceivers_SelectedIndexChanged);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(54, 406);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(100, 32);
            this.txtReceiver.TabIndex = 5;
            this.txtReceiver.TextChanged += new System.EventHandler(this.txtReceiver_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "To:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(577, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.lstReceivers);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessageInput);
            this.Controls.Add(this.title8);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MessagingForm";
            this.Text = "MessagingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessagingForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MessagingForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button title8;
        private System.Windows.Forms.TextBox txtMessageInput;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.ListBox lstReceivers;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label1;
    }
}