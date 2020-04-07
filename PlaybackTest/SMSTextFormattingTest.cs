using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Framework.Test
{
    [TestClass]
    public class SMSTextFormattingTest
    {
        // Arrange
        SMSProvider smsProvider = new SMSProvider();

        [TestMethod]
        public void CustomFormat_MessageStartsWithDateUppercaseThenLowercase()
        {

            // Act
            var result = smsProvider.CustomFormatter("message");

            // Assert
            Assert.AreEqual($"[{DateTime.Now}] Message", result);
        }

        [TestMethod]
        public void StartWithDateFormat_MessageStartsWithDate()
        {
            // Act
            var result = smsProvider.StartDateFormatter("message");

            // Assert
            Assert.AreEqual($"[{DateTime.Now}] message", result);
        }

        [TestMethod]
        public void EndWithDateFormat_MessageEndsWithDate()
        {
            // Act
            var result = smsProvider.EndDateFormatter("message");

            // Assert
            Assert.AreEqual($"message [{DateTime.Now}]", result);
        }

        [TestMethod]
        public void UppercaseFormat_MessageIsUppercase()
        {
            // Act
            var result = smsProvider.UppercaseFormatter("message");

            // Assert
            Assert.AreEqual("MESSAGE", result);
        }

        [TestMethod]
        public void LowercaseFormat_MessageIsLowercase()
        {
            // Act
            var result = smsProvider.LowercaseFormatter("Message");

            // Assert
            Assert.AreEqual("message", result);
        }
    }
}
