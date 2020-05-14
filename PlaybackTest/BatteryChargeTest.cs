using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using Moq;


namespace SimCorp.IMS.Framework.GUI
{
    [TestClass]
    public class BatteryChargeTest
    { 
        [TestMethod]
        public void Test_ChargeValueIsNotLargerThan100()
        {
            //Arrgange
            var exceptionThrown = false;
            try
            {
                //Act
                Battery.Charge = 101;
            }
            catch (Exception) { exceptionThrown = true; }

            //Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Test_ChargeValueIsNotLessThan0()
        {
            //Arrgange
            var exceptionThrown = false;
            try
            {
                //Act
                Battery.Charge = -1;
            }
            catch (Exception) { exceptionThrown = true; }

            //Assert
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void Test_DischargingThreadDecreaseBatteryCharge() {
            //Arrange
            Battery.Charge = 100;
            var discharge = new BatteryChargingThread();

            //Act
            var thread = new Thread(() => discharge.BatteryDischarging());
            thread.Start();
            Thread.Sleep(4000);
            thread.Abort();

            //Assert
            Assert.IsTrue(Battery.Charge<100);
        }


        [TestMethod]
        public void Test_ChargingThreadDecreaseBatteryCharge()
        {
            //Arrange
            Battery.Charge = 0;
            var discharge = new BatteryChargingThread();

            //Act
            var thread = new Thread(() => discharge.BatteryCharging());
            thread.Start();
            Thread.Sleep(4000);
            thread.Abort();

            //Assert
            Assert.IsTrue(Battery.Charge > 0);
        }


        [TestMethod]
        public void Test_DischargingTaskDecreaseBatteryCharge()
        {
            //Arrange
            var  batteryCharge= new BatteryChargingTask();
            Battery.Charge = 100;

            //Act
            var task = new Task(async () => await batteryCharge.BatteryDischarging());
            task.Start();
            task.Wait();

            //Assert
            Assert.IsTrue(Battery.Charge < 100);
        }

        [TestMethod]
        public void Test_ChargingTaskDecreaseBatteryCharge()
        {
            //Arrange
            var batteryCharge = new BatteryChargingTask();
            Battery.Charge = 0;

            //Act
            var task = new Task(async () => await batteryCharge.BatteryCharging());
            task.Start();
            task.Wait();

            //Assert
            Assert.IsTrue(Battery.Charge > 0);
        }
    }
}
