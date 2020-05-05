using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class MessagesFiltering{

        private List<Message> messages;
        public MessagesFiltering() {
            //Create a list of messages
            messages = new List<Message>();
        }
        
        //filter messages by selected user
        public List<Message> userComboBox_Filtering(List<Message> messages, string userName){
            var filteredmessages = messages.Where(x => x.User == userName).Select(x => x);
            return filteredmessages.ToList();
        }

        //filter messages by text fragment
        public List<Message> textSearch_Filtering(List<Message> messages, string text){
            var filteredmessages = messages.Where(x => x.Text.Contains(text)).Select(x => x);
            return filteredmessages.ToList();
        }

        //filter messages by date
        public List<Message> dateTime_Filtering(List<Message> messages, DateTime fromDate, DateTime toDate){
             var selection = messages.Where(x => x.RecievingTime <= toDate && x.RecievingTime >= fromDate).Select(x => x);
             var filteredmessages = selection.ToList();
             return filteredmessages;
        }

        //filter messages by all conditions
        public List<Message> allConditions_Filtering(List<Message> messages, string text, string userName,DateTime fromDate, DateTime toDate) {
            var filteredmessages1 = dateTime_Filtering(messages, fromDate, toDate);
            var filteredmessages2 = textSearch_Filtering(messages, text);
            var filteredmessages3 = userComboBox_Filtering(messages, userName);
            var filteredmessages = filteredmessages1.Intersect(filteredmessages2).ToList();
            filteredmessages = filteredmessages.Intersect(filteredmessages3).ToList();
            return filteredmessages;
        }

    }
}
