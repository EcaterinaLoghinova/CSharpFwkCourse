using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class MainCamera : Camera {
        public string ExtraFeatures { get; set; }
        public string WriteType()
        {
            return "Main Camera";
        }
    }
}
