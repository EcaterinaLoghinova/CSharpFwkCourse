using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.Framework.Test
{
    [TestClass]
    public class PlaybackTest
    {
        [TestMethod]
        public void Play_IPhoneHeadsetSelected_GetIPhoneHeadset(){

            // Arrange
            var output = new FakeOutput();
            var iphoneheadset = new iPhoneHeadset(output);

            // Act
            iphoneheadset.Play(iphoneheadset);
            var result = output.GetText();

            // Assert
            Assert.AreEqual("iPhoneHeadset", result);
        }

        [TestMethod]
        public void Play_SamsungHeadsetSelected_GetSamsungHeadset()
        {

            // Arrange
            var output = new FakeOutput();
            var samsungheadset = new SamsungHeadset(output);

            // Act
            samsungheadset.Play(samsungheadset);
            var result = output.GetText();

            // Assert
            Assert.AreEqual("SamsungHeadset", result);
        }

        [TestMethod]
        public void Play_UnofficialiPhoneHeadsetSelected_GetUnofficialiPhoneHeadset()
        {

            // Arrange
            var output = new FakeOutput();
            var unofficialiphoneheadset = new UnofficialIPhoneHeadset(output);

            // Act
            
            unofficialiphoneheadset.Play(unofficialiphoneheadset);
            var result = output.GetText();

            // Assert
            Assert.AreEqual("UnofficialIPhoneHeadset", result);
        }


        [TestMethod]
        public void Play_PhoneSpeakerSelected_GetPhoneSpeaker()
        {

            // Arrange
            var output = new FakeOutput();
            var phonespeaker = new PhoneSpeaker(output);

            // Act

            phonespeaker.Play(phonespeaker);
            var result = output.GetText();

            // Assert
            Assert.AreEqual("PhoneSpeaker", result);
        }
    }
}
