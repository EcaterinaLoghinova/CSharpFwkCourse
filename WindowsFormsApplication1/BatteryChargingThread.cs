using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimCorp.IMS.Framework.GUI
{
    public class BatteryChargingThread : IBatteryCharging
    {
        private ProgressBar chargeProgressBar;
        public BatteryChargingThread(ProgressBar ChargeProgressBar) {
           chargeProgressBar = ChargeProgressBar;
           threadCharge = new Thread(() => BatteryCharging());
        }

        //for unit test reasons
        public BatteryChargingThread(){
            chargeProgressBar = new ProgressBar();
            threadCharge = new Thread(() => BatteryCharging());
        }

        public Thread threadDischarge;
        public Thread threadCharge;
        static object locker = new Object();

        public void BatteryDischarging() {
            while (Battery.Charge > 0)
            {
                Battery.Charge--;
                GetBatteryStatusInfo(Battery.Charge);

                if (Battery.Charge == 5)
                {
                    MessageBox.Show("The battery is low. Please charge.");
                }

                Thread.Sleep(3000); // wait 3 seconds
            }

        }

        public void BatteryCharging()
        {
            lock (locker)
            {
                while (Battery.Charge < 100)
                {
                    Battery.Charge++;
                    GetBatteryStatusInfo(Battery.Charge);

                    if (chargeProgressBar.Value == 100)
                    {
                        MessageBox.Show("The battery is completely charged");
                        threadCharge.Abort();
                        threadDischarge.Start();
                        break;
                    }

                    Thread.Sleep(1000); // wait 1 second
                }
            }
        }

        public void GetBatteryStatusInfo(int batteryCharge)
        {
             chargeProgressBar.Invoke(new Action(() => chargeProgressBar.Value = batteryCharge));
            //print progress in %
            chargeProgressBar.CreateGraphics().DrawString(batteryCharge.ToString() + '%', new Font("Arial",
            (float)9.25, FontStyle.Bold), Brushes.Black, new PointF(chargeProgressBar.Width / 2 - 10, chargeProgressBar.Height / 2 - 7));
        }

        public void StartCharging() {
            threadCharge = new Thread(() => BatteryCharging());
            threadCharge.Start();
        }

        public void StartDischarging()
        {
            threadDischarge = new Thread(() => BatteryDischarging());
            threadDischarge.Start();
        }

        public void StopCharging() {
            if (threadCharge.IsAlive)
            {
                threadCharge.Abort();
            }
        }
    }
}
