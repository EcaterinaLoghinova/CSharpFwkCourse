using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{ 
    public enum ChargeType
    {
        chargeTask,
        chargeThread
    }

     public interface IChargeFactory
    {
      IBatteryCharging CreateChargeType(ChargeType type);
    }
}
