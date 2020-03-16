using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class SelfieCamera : Camera {

        private string cameraType;
        public SelfieCamera(){
            cameraType = "Selfie Camera";
        }
        public string HasVideo(bool hasVideo) {
            if (hasVideo == true)
            { return "Yes"; }
         else
            { return "No"; }
        }
        public string WriteType()
        {
            return cameraType;
        }
    }
   
}
