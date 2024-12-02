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
        private List<Conversation> storedConversations;
        private string currentReceiver;
        public MessagingForm()
        {
            InitializeComponent();
            Program.centerControl(title, panel1);
            user = ThisLogin.Username;
            storedConversations = Storage.Conversations;
            currentReceiver = UserConversation().Count > 0 ? UserConversation()[0].Receiver : "";
            DisplayReceivers(user);
            DisplayConversation(user, currentReceiver);
        }
        private Conversation GetConversation(string sender, string receiver)
        {
            return storedConversations.FirstOrDefault(c => 
            (c.Sender == sender && c.Receiver == receiver) ||
            (c.Sender == receiver && c.Receiver == sender));
        }
        private List<Conversation> UserConversation()
        {
            //Get list of all conversations of the user of this current login session
            var list = storedConversations.Where(c =>
            c.Sender == user || c.Receiver == user);
            return list.ToList();
        }
        private void AddMessage(string sender, string message, string recceiver)
        {
            string formattedMessage = $"{sender}: {message}";
            var conversation = GetConversation(sender, recceiver);
            if (conversation == null)
            {
                conversation = new Conversation(sender, recceiver);
                storedConversations.Add(conversation);
            }
            conversation.Contents.Add(formattedMessage);
            DisplayReceivers(user);
            DisplayConversation(user, currentReceiver);
        }
        private void DisplayConversation(string sender, string receiver)
        {
            lstMessages.Items.Clear();
            var conversation = GetConversation(sender, receiver);
            if (conversation != null)
            {
                foreach (var message in conversation.Contents)
                {
                    lstMessages.Items.Add(message);
                }
            }
        }
        private void DisplayReceivers(string sender)
        {
            lstReceivers.Items.Clear();
            foreach (var conversation in UserConversation())
            {
                lstReceivers.Items.Add(conversation.Receiver);
            }
        }
        private void RandomResponse()
        {
            var r = new Random();
            string response = $"Random answer no.{r.Next(100)}";
            AddMessage(currentReceiver, response, user);
        }
        private void btnSend_Click(object sender, EventArgs e)
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
            AddMessage(user, message, currentReceiver);
            RandomResponse();
            txtMessageInput.Clear();
        }

        private void lstReceivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReceivers.SelectedItem != null)
            {
                currentReceiver = lstReceivers.SelectedItem.ToString();
                txtReceiver.Text = currentReceiver;
                DisplayConversation(user, currentReceiver);
            }
        }
        private void txtReceiver_TextChanged(object sender, EventArgs e)
        {
            currentReceiver = txtReceiver.Text;
        }

        private void MessagingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.ShowMainForm();
        }

        private void MessagingForm_Resize(object sender, EventArgs e)
        {
            Program.centerControl(title, panel1);
        }
    }
}
