using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.Framework.Charger;

namespace SimCorp.IMS.Framework.GUI
{
    public class FormOutput : IOutput {

        private RichTextBox richTextBox;

        public FormOutput(RichTextBox richtextbox){
            richTextBox = richtextbox;
        }
                 
        public void Write(string text)
        {
            richTextBox.Text = text + Environment.NewLine;
        }

        public void WriteLine(string text)
        {
            richTextBox.AppendText(text + Environment.NewLine);
        }

        public void WriteInfo()
        {
            richTextBox.AppendText(" Set charger to the Mobile... " + Environment.NewLine);
            richTextBox.AppendText(" Charge the Mobile: " + Environment.NewLine);
        }

    }
}
