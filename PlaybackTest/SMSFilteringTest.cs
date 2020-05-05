using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Linq;

namespace SimCorp.IMS.Framework.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SMSFilteringTest
    {
        private List<Message> messages;
        private MessagesFiltering messageFilter;

        public SMSFilteringTest()
        {
            //Create a list of messages
            messages = new List<Message>();

            //Add data to the list of messages
            messages.Add(new Message() { User = "Jhon", Text = "Today's game was awesome! Thanks for your participation", RecievingTime = new DateTime(2018, 8, 31, 20, 48, 45) });
            messages.Add(new Message() { User = "Jhon", Text = "Hi! How are you doing?", RecievingTime = new DateTime(2020, 1, 3, 16, 32, 7) });
            messages.Add(new Message() { User = "Bob", Text = "Good morning! Please call me back ASAP", RecievingTime = new DateTime(2020, 4, 13, 9, 10, 6) });
            messages.Add(new Message() { User = "TVshop", Text = "Hello! Christmas sales are coming!", RecievingTime = new DateTime(2019, 12, 15, 9, 20, 3) });
            messages.Add(new Message() { User = "TVshop", Text = "Hello! We have special offer for you!", RecievingTime = new DateTime(2020, 2, 5, 12, 15, 16) });

            messageFilter = new MessagesFiltering();
        }

        [TestMethod]
        public void textSearch_MessagesFilteredByText()
        {
            // Arrange
            var expected = messages.GetRange(3, 2);

            // Act
            var result = messageFilter.textSearch_Filtering(messages, "Hello");
            var difference = expected.Except(result).ToList();
 
            // Assert
            Assert.IsTrue(difference.Count == 0);
        }

        [TestMethod]
        public void userSearch_MessagesFilteredByUser()
        {
            // Arrange
            List<Message> expected =new List<Message>();
            expected.Add(messages[2]);

            // Act
            var result = messageFilter.userComboBox_Filtering(messages, "Bob");
            var difference = expected.Except(result).ToList();

            // Assert        
            Assert.IsTrue(difference.Count == 0);
        }

        [TestMethod]
        public void dateSearch_MessagesFilteredByDate()
        {
            // Arrange
            DateTime fromDate = new DateTime(2020, 1, 1, 0, 0, 0);
            DateTime toDate = new DateTime(2020, 4, 15, 0, 0, 0);
            var expected = messages.GetRange(1, 2);
            expected.Add(messages[4]);

            // Act
            var result = messageFilter.dateTime_Filtering(messages, fromDate, toDate);
            var difference = expected.Except(result).ToList();

            // Assert
            Assert.IsTrue(difference.Count == 0);

        }

        [TestMethod]
        public void allFilters_MessagesFilteredByAllConditions()
        {
            // Arrange
            DateTime fromDate = new DateTime(2018, 1, 1, 0, 0, 0);
            DateTime toDate = new DateTime(2020, 4, 15, 0, 0, 0);
            string userName = "Jhon";
            string text = "you";
            var expected = messages.GetRange(0,2);

            // Act
            var result = messageFilter.allConditions_Filtering(messages, text, userName, fromDate, toDate);
            var difference = expected.Except(result).ToList();

            // Assert
            Assert.IsTrue(difference.Count == 0);
        }
    }
}
