using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class MainCamera : Camera {

        private string cameraType;
        public MainCamera() {  
            cameraType = "Main camera";
        }

        public string ExtraFeatures { get; set; }
        public string WriteType()
        {
            return cameraType;
        }
    }
}
