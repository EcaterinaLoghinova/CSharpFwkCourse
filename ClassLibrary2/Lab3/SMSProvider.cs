using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimCorp.IMS.Framework
{ 

  public class SMSProvider{

        public SMSProvider()
        {
            smsStorage = new SMSStorage();
        }

        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSReceived;
        
        //Delegates for message formatting
        public delegate string FormatDelegate(string text);
        public readonly FormatDelegate CustomFormatter = new FormatDelegate(CustomFormat);
        public readonly FormatDelegate StartDateFormatter = new FormatDelegate(StartWithDateFormat);
        public readonly FormatDelegate EndDateFormatter = new FormatDelegate(EndWithDateFormat);
        public readonly FormatDelegate UppercaseFormatter = new FormatDelegate(UppercaseFormat);
        public readonly FormatDelegate LowercaseFormatter = new FormatDelegate(LowercaseFormat);
        private string formattedMessage;
        private SMSStorage smsStorage;

        //Raise rhe ecvent
        public void RaiseSMSReceivedEvent(string message)
        {
            var handler = SMSReceived;
            if (handler != null) {
                handler(message);
            }
        }

        // Format a message with Custom formatting:
        // Date&Time in the befinnig, first letter is uppercase and all others are lowercase 
        public static string CustomFormat(string message)
        {
            return ($"[{DateTime.Now}] ") + char.ToUpper(message[0]) + message.Substring(1).ToLower();
        }

        // Format a message starting with date and time 
        public static string StartWithDateFormat(string message)
        {
            return ($"[{DateTime.Now}] {message}");
        }

        // Format a message ending with date and time 
        public static string EndWithDateFormat(string message)
        {
            return ($"{message} [{DateTime.Now}]");
        }

        // Format a message with uppercase letters
        public static string UppercaseFormat(string message)
        {
            return (message.ToUpper());
        }

        // Format a message with lowercase letters
        public static string LowercaseFormat(string message)
        {
            return (message.ToLower());
        }


        //Generate messages according to the selected formatting
        public string GenerateMessage(int index, string message){

            RaiseSMSReceivedEvent(message);
            formattedMessage = MessageFormatting(index, message);
            smsStorage.RaiseSMSAddedEvent(formattedMessage);
            SMSStorage.AddMessage(formattedMessage);
            return formattedMessage;
        }

        private string MessageFormatting(int index, string message)
        {
            switch (index)
            {
                case 0:
                    formattedMessage = message + Environment.NewLine;
                    break;
                case 1:
                    formattedMessage = CustomFormatter($"{message} {Environment.NewLine}");
                    break;
                case 2:
                    formattedMessage = StartDateFormatter($"{message} {Environment.NewLine}");
                    break;
                case 3:
                    formattedMessage = EndDateFormatter($"{Environment.NewLine}{message}");
                    break;
                case 4:
                    formattedMessage = UppercaseFormatter($"{message} {Environment.NewLine}");
                    break;
                case 5:
                    formattedMessage = LowercaseFormatter($"{message} {Environment.NewLine}");
                    break;
                default:
                    formattedMessage = message + Environment.NewLine;
                    break;
            }
            return formattedMessage;
        }

    }
}
