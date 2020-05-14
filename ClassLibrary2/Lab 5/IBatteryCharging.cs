using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public interface IBatteryCharging
    {
        void StartCharging();
        void StartDischarging();
        void StopCharging();
        void GetBatteryStatusInfo(int batteryCharge);
    }
}
