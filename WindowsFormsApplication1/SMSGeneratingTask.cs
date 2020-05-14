using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{
    public class SMSGeneratingTask : ISMSGenerating
    {
        public SMSProvider smsProvider;
        public int messageNumber;
        private RichTextBox richTextBox;
        private Task genMessageTask;
        private CancellationToken token;
        private CancellationTokenSource cts;
        private int formatIndex;

        public SMSGeneratingTask(RichTextBox recievedMessagesRichTextBox)
        {
            richTextBox = recievedMessagesRichTextBox;
            smsProvider = new SMSProvider();
            messageNumber = SMSStorage.messages.Count();

            cts = new CancellationTokenSource();
            token = cts.Token;
        }

        private void MessageGenerating(int index)
        {  
           messageNumber++;
           var message = $"Message #{messageNumber.ToString()} has been recieved.";
           var formattedMessage = smsProvider.GenerateMessage(index, message);
           richTextBox.Invoke(new Action(() => richTextBox.AppendText(formattedMessage)));
        }

        public async void RunMessageGenerating(int index)
        {
            formatIndex = index;

            cts = new CancellationTokenSource();
            token = cts.Token;

            while (!token.IsCancellationRequested)
            {
                genMessageTask = new Task(() => { MessageGenerating(formatIndex); }, token);
                genMessageTask.Start();
                await genMessageTask;
                await Task.Delay(2000); // wait 2 seconds
            }
        }

        public void StopMessageGenerating()
        {
            cts.Cancel();
        }

    }
}
