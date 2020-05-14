using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimCorp.IMS.Framework
{
    public class BatteryChargingTask : IBatteryCharging
    {
        private ProgressBar chargeProgressBar;
        private CancellationToken token;
        private CancellationTokenSource cts;
        private Task dischargeBatteryTask;
        private Task chargeBatteryTask;
        private bool chargingIsActive;

        public BatteryChargingTask(ProgressBar ChargeProgressBar)
        {
            chargeProgressBar = ChargeProgressBar;

            cts = new CancellationTokenSource();
            token = cts.Token;

            chargingIsActive = false;
        }

        public BatteryChargingTask()
        {
            chargeProgressBar = new ProgressBar();

            cts = new CancellationTokenSource();
            token = cts.Token;

            chargingIsActive = false;
        }

        static object locker = new Object();

        public async Task BatteryDischarging()
        {
            if (Battery.Charge > 0)
            {
                Battery.Charge--;

                if (Battery.Charge == 5 && chargingIsActive == false)
                {
                    MessageBox.Show("The battery is low. Please charge.");
                }
            }
            await Task.Delay(3000); // wait 3 seconds
        }

        public async Task BatteryCharging()
        {
            lock (locker)
            {
                if (Battery.Charge < 100)
                {
                    Battery.Charge++;

                    if (Battery.Charge == 100)
                    {
                        MessageBox.Show("The battery is completely charged");
                        chargingIsActive = false;
                    }
                }
            }

            await Task.Delay(1000); // wait 1 second
        }

        public void GetBatteryStatusInfo(int batteryCharge)
        {
            chargeProgressBar.Invoke(new Action(() => chargeProgressBar.Value = batteryCharge));
            //print progress in %
            chargeProgressBar.CreateGraphics().DrawString(batteryCharge.ToString() + '%', new Font("Arial",
            (float)9.25, FontStyle.Bold), Brushes.Black, new PointF(chargeProgressBar.Width / 2 - 10, chargeProgressBar.Height / 2 - 7));
        }

        public async void StartCharging()
        {
            chargingIsActive = true;
            cts = new CancellationTokenSource();
            token = cts.Token;
            while (!token.IsCancellationRequested && chargingIsActive == true)
            {
                chargeBatteryTask = new Task(async() => await BatteryCharging());
                chargeBatteryTask.Start();
                await Task.Delay(1000); // wait 1 second
                await chargeBatteryTask;
                GetBatteryStatusInfo(Battery.Charge);
            }
        }

        public async void StartDischarging()
        {
            cts = new CancellationTokenSource();
            token = cts.Token;
            while (!token.IsCancellationRequested)
            {
                dischargeBatteryTask = new Task(async () => await BatteryDischarging());
                dischargeBatteryTask.Start();
                await Task.Delay(3000); // wait 3 seconds
                await dischargeBatteryTask;
                GetBatteryStatusInfo(Battery.Charge);
            }
        }

        public void StopCharging()
        {
            if (chargingIsActive == true) { 
                cts.Cancel();
                chargingIsActive = false;
             }

            cts = new CancellationTokenSource();
            token = cts.Token;
        }
    }
}
