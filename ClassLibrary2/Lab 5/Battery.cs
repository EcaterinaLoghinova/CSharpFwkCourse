using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class Battery
    {
       static int _charge;
       public static int Charge {
            get { return _charge; }

            set {
                //Charge cannot be larger than 100 or less than 0
                if (value > 100 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Charge", "Charge value must be in range 0 to 100"); ;
                }
                else
                    _charge = value;
            }
        }

    }
}
