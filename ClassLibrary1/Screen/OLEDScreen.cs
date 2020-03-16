using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class OLEDScreen : ColorfulScreen {

        private string screenType;

        public OLEDScreen(){
            screenType = "OLED Screen";
        }


        public override void Show(IScreenImage screenImage)
        {
            //here logic for OLED screen can be added
        }
        public override string ToString()
        {
            return screenType;
        }
    }
}
