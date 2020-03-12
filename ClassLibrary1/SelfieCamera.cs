using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SelfieCamera : Camera {
        public string HasVideo(bool hasVideo) {
            if (hasVideo == true)
            { return "Yes"; }
         else
            { return "No"; }
        }
        public string WriteType()
        {
            return "Selfie Camera";
        }
    }
   
}
