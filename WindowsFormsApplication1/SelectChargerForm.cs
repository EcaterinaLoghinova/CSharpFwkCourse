using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimCorp.IMS.Framework.Charger;

namespace SimCorp.IMS.Framework.GUI
{
    public partial class SelectChargerForm : Form
    {
     
        private string text;
        private FormOutput Output;
        private RadioButton radioButton;

        public SelectChargerForm()
        {
            InitializeComponent();
            Output = new FormOutput(richTextBox1);
            radioButton = new RadioButton();
        }

    
        private void radioButton1_CheckedChanged (object sender, EventArgs e)
        {
            text = nameof(MicroUSB);
            radioButton = radioButton1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            text = nameof(TypeCUSB);
            radioButton = radioButton2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            text = nameof(iPhoneCharger);
            radioButton = radioButton3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            text = nameof(WirelessCharger);
            radioButton = radioButton4;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Output.Write(text+" selected.");
            Output.WriteInfo();
            Output.WriteLine(text+" charger.");           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
