using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{
    public partial class MessageBoxForm : Form
    {
        private SMSProvider smsProvider;
        private int messagenumber;

        public MessageBoxForm()
        {
            InitializeComponent();
            smsProvider = new SMSProvider();

        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            messagenumber = 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            messagenumber++;
            OnSMSReceived($"Message #{messagenumber} recieved.");
        }

        private void OnSMSReceived(string message)
        {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReceived), message);
                return;        
            }         

            richTextBox1.AppendText(smsProvider.GenerateMessage(comboBox1.SelectedIndex,message));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
