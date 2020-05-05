﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{
    public partial class MessageBoxForm : Form
    {
        private SMSStorage smsStorage;
        private int messagenumber;
        private List<Message> messages;
        private MessagesFiltering messageFilter;


        public MessageBoxForm()
        {
            InitializeComponent();
            smsStorage= new SMSStorage();
            messageFilter = new MessagesFiltering();

            //Create a list of messages
            messages = new List<Message>();

            //Add data to the list of messages
            messages.Add(new Message() { User = "Jhon", Text = "Today's game was awesome! Thanks for your participation", RecievingTime = new DateTime(2018, 8, 31, 20, 48, 45) });
            messages.Add(new Message() {User = "Jhon", Text = "Hi! How are you doing?", RecievingTime = new DateTime(2020,1,3,16,32,7)});
            messages.Add(new Message() {User = "Bob", Text = "Good morning! Please call me back ASAP", RecievingTime = new DateTime(2020,4,13,9,10,6)});
            messages.Add(new Message() {User = "TVshop", Text = "Hello! Christmas sales are coming!", RecievingTime = new DateTime(2019, 12, 15, 9, 20, 3)});
            messages.Add(new Message() {User = "TVshop", Text = "Hello! We have special offer for you!", RecievingTime = new DateTime(2020, 2, 5, 12, 15, 16)});

            //Show messages on the form
            ShowMessage(messages);
        }
        
        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            messagenumber = 0;

            //populate userComboBox with unique user items
            List<string> users = messages.Select(x => x.User).Distinct().ToList();
            foreach (string user in users)
            {
                userComboBox.Items.Add(user);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            messagenumber++;
            OnSMSReceived($"Message #{messagenumber} has been recieved.");
        }

        private void OnSMSReceived(string message)
        {
            if (InvokeRequired) {
                Invoke(new SMSStorage.SMSAddedDelegate(OnSMSReceived), message);
                return;        
            }
            var now = System.DateTime.Now;
           recievedMessagesRichTextBox.AppendText(now+" "+message+Environment.NewLine);
        }
        
        private void selectFormattingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            recievedMessagesRichTextBox.Clear();
            SelectFormattingLabel.Visible = false;
        }
       
        private void ShowMessage(List<Message> messages) {
            messageListView.Items.Clear();
            foreach (Message message in messages) {
                messageListView.Items.Add(new ListViewItem(new[] { message.User, message.Text}));
            }
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByContactLabel.Visible = false;
            if (allFiltersCheckBox.Checked == true)
            {
                allFilters_Search();
            }
            else
            {
                //filter messages by user name
                List<Message> filteredmessages = messageFilter.userComboBox_Filtering(messages, (string)userComboBox.SelectedItem);
                ShowMessage(filteredmessages);
            }

        }

        private void textSearchButton_Click(object sender, EventArgs e)
        {
            if (allFiltersCheckBox.Checked == true)
            {
                allFilters_Search();
            }
            else
            {
                //filter messages by text
                List<Message> filteredmessages = messageFilter.textSearch_Filtering(messages, messageTextBox.Text);
                ShowMessage(filteredmessages);
            }
        }

        //filter messages by dates
        private void dateTimeFilter() {
            DateTime fromDate = fromDateTimePicker.Value;
            DateTime toDate = toDateTimePicker.Value;
            if (fromDate.Date > toDate.Date)
            {
                MessageBox.Show("'From date' must be earlier than or the same as 'To date'");
            }
            else
            {
                List<Message> filteredmessages = messageFilter.dateTime_Filtering(messages, fromDate, toDate);
                ShowMessage(filteredmessages);
            }
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (allFiltersCheckBox.Checked == true)
            {
                allFilters_Search();
            }
            else
            {
                dateTimeFilter();
            }
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (allFiltersCheckBox.Checked == true)
            {
                allFilters_Search();
            }
            else
            {
                dateTimeFilter();
            }
        }
  
        private void allFiltersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allFiltersCheckBox.Checked == true)
            {
                allFilters_Search();
            }
        }

        //filter messages by all conditions
        private void allFilters_Search()
        {
              DateTime fromDate = fromDateTimePicker.Value;
              DateTime toDate = toDateTimePicker.Value;
              string text = messageTextBox.Text;
              string userName = (string)userComboBox.SelectedItem;
              var filteredmessages = messageFilter.allConditions_Filtering(messages, text, userName, fromDate, toDate);
              ShowMessage(filteredmessages);        
        }

    }
}
