using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Framework.Test
{
    [TestClass]
    public class SMSStorageTest
    {

        [TestMethod]
        public void Test_NewMessageAddedToStorage()
        {
            //Act
            SMSStorage.AddMessage("Message1");

            //Assert
            Assert.IsTrue(SMSStorage.messages.Contains("Message1"));
        }

        [TestMethod]
        public void Test_MessageRemovedFromStorage()
        {
            //Act
            SMSStorage.RemoveMessage(SMSStorage.messages.Count-1);

            //Assert
            Assert.IsFalse(SMSStorage.messages.Contains("Message1"));
        }

        [TestMethod]
        public void Test_GeneratingMessage_MessageIsSaved()
        {
            //Arrange
            var smsProvider = new SMSProvider();

            //Act
            string text = smsProvider.GenerateMessage(-1, "Message recieved");

            //Assert
            Assert.IsTrue(SMSStorage.messages.Contains(text));
        }
    }
}
