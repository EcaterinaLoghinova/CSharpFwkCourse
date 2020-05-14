using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{
    public class SMSGeneratingFactory : ISMSGeneratingFactory
    {
        private RichTextBox richTextBox;
        public SMSGeneratingFactory(RichTextBox recievedMessagesRichTextBox)
        {
            richTextBox = recievedMessagesRichTextBox;
        }
        public ISMSGenerating CreateGeneratingType(GenerateType type)
        {
            switch (type)
            {
                case GenerateType.smsGeneratingThread:
                    return new SMSGeneratingThread(richTextBox);
                case GenerateType.smsGeneratingTask:
                    return new SMSGeneratingTask(richTextBox);
                default:
                    return new SMSGeneratingThread(richTextBox);
            }
        }
    }
}
