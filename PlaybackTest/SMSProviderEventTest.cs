using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Framework.Test
{
    [TestClass]
    public class SMSProviderEventTest
    {

        [TestMethod]
        public void Test_SMSProviderEventIsRaised()
        {
            //Arrange
            bool handlerCalled = false;
            var smsProvider = new SMSProvider();
            SMSProvider.SMSRecievedDelegate handler = (message) =>
            {
                handlerCalled = true;
            };

            smsProvider.SMSReceived += handler;

            //Act
            string text = smsProvider.GenerateMessage(-1,"Message recieved");

            //Assert
            Assert.IsTrue(handlerCalled);

        }
    }
}
