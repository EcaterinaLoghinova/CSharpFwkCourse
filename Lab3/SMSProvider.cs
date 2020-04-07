using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace SimCorp.IMS.Framework
{ 

    public class SMSProvider{

        AutoResetEvent autoEvent = new AutoResetEvent(false);
       
   
       // Timer timer = new Timer(statusChecker.Check);

        public SMSProvider() {
            
        }

        public delegate void SMSRecievedDelegate(string message);

        public event SMSRecievedDelegate SMSReceived;

        private delegate string FormatDelegate();
    
        private void RaiseSMSReceivedEvent(string message)
        {
            var handler = SMSReceived;
            if (handler != null) {
                handler(message);
            }
        }

        //Format message starting with Date&Time 
        private static string StartWithDateTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        //Format message ending with Date&Time 
        private static string EndWithDateTime(string message)
        {
            return $"{message} [{DateTime.Now}] ";
        }

        //Format message with lowercase letters
        private static string LowerCase(string message)
        {
            return $"{message.ToLower()} ";
        }

        //Format message with uppercase letters
        private static string UpperCase(string message)
        {
            return $"{message.ToUpper()} ";
        }

        //Custom formatting
        private static string Custom(string message)
        {
            //First letter is uppercase
            message = char.ToUpper(message[0]) + message.Substring(1).ToLower();
            return $"{message} ";

        }
    }
}
