using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCorp.IMS.Framework.GUI
{
    public class ChargeFactory : IChargeFactory
    {
        private ProgressBar chargeProgressBar;
        public ChargeFactory(ProgressBar ChargeProgressBar) {
            chargeProgressBar = ChargeProgressBar;
        }
        public IBatteryCharging CreateChargeType(ChargeType type) {
            switch (type)
            {
                case ChargeType.chargeThread:
                    return new BatteryChargingThread(chargeProgressBar);
                case ChargeType.chargeTask:
                    return new BatteryChargingTask(chargeProgressBar);
                default:
                    return new BatteryChargingThread(chargeProgressBar);
            }
        }
    }
}
