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
    public partial class CallsForm : Form

    {   
        private Contact contact1 = new Contact() { ContactId = 1, Name = "Jhon", PhoneNumber = "+3801231234"};
        private Contact contact2 = new Contact() { ContactId = 2, Name = "Bob", PhoneNumber = "+3801112223" };
        private Contact contact3 = new Contact() { ContactId = 3, Name = "Bill", PhoneNumber = "+3809009009" };

        public CallsForm()
        {
            InitializeComponent();
            CallsStorage.AddCall(new Call() { contact = contact1, callTimeDate = new DateTime(2018, 8, 31, 20, 48, 45), Direction = "incoming" });
            CallsStorage.AddCall(new Call() { contact = contact3, callTimeDate = new DateTime(2019, 12, 15, 9, 20, 3), Direction = "incoming" });
            CallsStorage.AddCall(new Call() { contact = contact1, callTimeDate = new DateTime(2020, 1, 3, 16, 32, 7), Direction = "incoming" });
            CallsStorage.AddCall(new Call() { contact = contact2, callTimeDate = new DateTime(2020, 2, 5, 12, 15, 16), Direction = "outgoing" });
            CallsStorage.AddCall(new Call() { contact = contact2, callTimeDate = new DateTime(2020, 2, 5, 12, 17, 16), Direction = "outgoing" });
        }

        private void ShowCalls(List<Call> calls)
        {
            int i = 0;
            foreach (Call call in calls)
            {
                string[] stringArray = CallsStorage.callLog[i].ToArray();
                callGridView.Rows.Add(call.contact.Name, call.contact.PhoneNumber, call.Direction);
                DataGridViewComboBoxCell logCell = (DataGridViewComboBoxCell) callGridView.Rows[i].Cells[callLog.Index];
                var n = stringArray.Length;
                logCell.Value = stringArray[n-1];
                for (int j=n-1; j>=0; j--)
                {
                    logCell.Items.Add(stringArray[j]);
                }
                i++;
            }
        }

        private void CallsForm_Load(object sender, EventArgs e)
        {
            ShowCalls(CallsStorage.callsList);
        }
    }
}
