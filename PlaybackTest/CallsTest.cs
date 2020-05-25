using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimCorp.IMS.Framework.Test
{
    [TestClass]
    public class CallsTest
    {
        private Call call = new Call();
        private Contact contact1 = new Contact() { ContactId = 1, Name = "Jhon", PhoneNumber = "+3801231234" };
        private Contact contact2 = new Contact() { ContactId = 2, Name = "Bob", PhoneNumber = "+3801112223" };
        private Contact contact3 = new Contact() { ContactId = 3, Name = "Bill", PhoneNumber = "+3809009009" };

        [TestMethod]
        public void Test_CallsAreSortedByDate()
        {

            //Act
            CallsStorage.AddCall(new Call() { contact = contact1, callTimeDate = new DateTime(2020, 1, 3, 16, 32, 7), Direction = "incoming" });
            CallsStorage.AddCall(new Call() { contact = contact2, callTimeDate = new DateTime(2018, 8, 31, 20, 48, 45), Direction = "incoming" });
            CallsStorage.AddCall(new Call() { contact = contact3, callTimeDate = new DateTime(2020, 2, 5, 12, 15, 16), Direction = "outgoing" });
            CallsStorage.AddCall(new Call() { contact = contact1, callTimeDate = new DateTime(2019, 12, 15, 9, 20, 3), Direction = "incoming" });
            var calls = CallsStorage.callsList;

            //Assert
            Assert.AreEqual(new DateTime(2018, 8, 31, 20, 48, 45), calls[3].callTimeDate);
            Assert.AreEqual(new DateTime(2019, 12, 15, 9, 20, 3), calls[2].callTimeDate);
            Assert.AreEqual(new DateTime(2020, 1, 3, 16, 32, 7), calls[1].callTimeDate);
            Assert.AreEqual(new DateTime(2020, 2, 5, 12, 15, 16), calls[0].callTimeDate);

            CallsStorage.RemoveCall(2);
            calls = CallsStorage.callsList;

            Assert.AreEqual(new DateTime(2018, 8, 31, 20, 48, 45), calls[2].callTimeDate);
            Assert.AreEqual(new DateTime(2020, 1, 3, 16, 32, 7), calls[1].callTimeDate);
            Assert.AreEqual(new DateTime(2020, 2, 5, 12, 15, 16), calls[0].callTimeDate);
        }

        [TestMethod]
        public void Test_SimilarCallsHandling()
        {
            CallsStorage.AddCall(new Call() { contact = contact3, callTimeDate = new DateTime(2020, 03, 01, 9, 20, 3), Direction = "incoming" });
            var n = CallsStorage.callsList.Count;
            //Add similar call
            CallsStorage.AddCall(new Call() { contact = contact3, callTimeDate = new DateTime(2020, 03, 02, 9, 20, 3), Direction = "incoming" });

            //the number of call records must not be changed
            Assert.AreEqual(n, CallsStorage.callsList.Count);
            Assert.AreEqual(n, CallsStorage.callLog.Count);

            //two records in the call log for the last calling contact
            Assert.AreEqual(2, CallsStorage.callLog[0].Count);

            //Add new different call
            CallsStorage.AddCall(new Call() { contact = contact3, callTimeDate = new DateTime(2020, 03, 02, 9, 20, 3), Direction = "outgoing" });
            Assert.AreEqual(n+1, CallsStorage.callsList.Count);
            Assert.AreEqual(n+1, CallsStorage.callLog.Count);
            //for new calls there is only one timestamp in the last log record
            Assert.AreEqual(1, CallsStorage.callLog[0].Count);

            //remove the last call info
            CallsStorage.RemoveCall(0);
            n = CallsStorage.callsList.Count;

            Assert.AreEqual(n, CallsStorage.callLog.Count);
            Assert.AreEqual(2, CallsStorage.callLog[0].Count);

        }
    }
}
