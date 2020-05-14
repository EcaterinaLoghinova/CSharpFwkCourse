using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{    
    public class SMSGeneratingThread : ISMSGenerating
    {
        public SMSProvider smsProvider;
        public int messageNumber;
        private RichTextBox richTextBox;
        private Thread genMessageThread;
        public SMSGeneratingThread(RichTextBox recievedMessagesRichTextBox)
        {
            richTextBox = recievedMessagesRichTextBox;
            smsProvider = new SMSProvider();
            messageNumber = SMSStorage.messages.Count();
            genMessageThread = new Thread(() => MessageGenerating(0));
        }

        private void MessageGenerating(int index) {

            while (true)
            {
                messageNumber++;
                var message = $"Message #{messageNumber.ToString()} has been recieved.";
                var formattedMessage = smsProvider.GenerateMessage(index, message);
                richTextBox.Invoke(new Action(() => richTextBox.AppendText(formattedMessage)));
                Thread.Sleep(2000); // wait 2 seconds 

            }
        }

        
        public void RunMessageGenerating(int index)
        {   
            genMessageThread = new Thread(() => { MessageGenerating(index); });     
            genMessageThread.Start(); 
        }

        public void StopMessageGenerating()
        {
            if (genMessageThread.IsAlive)
                 genMessageThread.Abort();
        }

    }
}
