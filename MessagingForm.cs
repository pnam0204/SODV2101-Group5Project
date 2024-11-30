using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5Project
{
    public partial class MessagingForm : Form
    {
        private string user;
        private Dictionary<string, List<string>> conversations;
        private string currentReceiver;
        public MessagingForm()
        {
            InitializeComponent();
            user = ThisLogin.Username;
            conversations = new Dictionary<string, List<string>>();
        }
        private void AddMessage(string sender, string message)
        {
            string formattedMessage = $"{sender}: {message}";

            if (!conversations.ContainsKey(currentReceiver))
            {
                conversations[currentReceiver] = new List<string>();
                lstReceivers.Items.Add(currentReceiver);
            }

            conversations[currentReceiver].Add(formattedMessage);

            DisplayConversation(currentReceiver);
        }
        private void DisplayConversation(string receiver)
        {
            lstMessages.Items.Clear();

            if (conversations.ContainsKey(receiver))
            {
                foreach (var message in conversations[receiver])
                {
                    lstMessages.Items.Add(message);
                }
            }
        }
        public void AutoResponse()
        {
            AddMessage("System", "Message sent");
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentReceiver))
            {
                MessageBox.Show("Please enter a receiver's name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = txtMessageInput.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddMessage(user, message);

            AutoResponse();

            txtMessageInput.Clear();
        }

        private void lstReceivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceivers.SelectedItem != null)
            {
                currentReceiver = lstReceivers.SelectedItem.ToString();
                txtReceiver.Text = currentReceiver;
                DisplayConversation(currentReceiver);
            }
        }
        private void txtReceiver_TextChanged(object sender, EventArgs e)
        {
            currentReceiver = txtReceiver.Text;
        }

        private void MessagingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShowMainForm();
        }
    }
}
