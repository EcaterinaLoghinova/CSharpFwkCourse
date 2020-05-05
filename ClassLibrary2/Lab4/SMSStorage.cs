using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class SMSStorage
    {
        public static List<string> messages;

        public SMSStorage(){
            messages = new List<string>();
        }

        public static void AddMessage(string newMessage)
        {
           messages.Add(newMessage);
        }

        public static void RemoveMessage(int index) {
             messages.RemoveAt(index);
        }

        public delegate void SMSAddedDelegate(string message);
        public event SMSAddedDelegate SMSAdded;

        public delegate void SMSRemovedDelegate(string message);
        public event SMSRemovedDelegate SMSRemoved;

        public void RaiseSMSAddedEvent(string message)
        {
            var handler = SMSAdded;
            if (handler != null)
            {
                handler(message);
            }
        }

        public void RaiseSMSRemovedEvent(string message)
        {
            var handler = SMSRemoved;
            if (handler != null)
            {
                handler(message);
            }
        }

    }
}
