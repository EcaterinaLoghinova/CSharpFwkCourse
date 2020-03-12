using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class ColorfulScreen : ScreenBase {
        public override void Show(IScreenImage screenImage) { 
            //here code that draws colorful image could be added
        }

        public override void Show(IScreenImage screenImage, int brightness){
            //brighness parameter can be used here
        }
        public override string ToString()
        {
            return "Colorful Screen";
        }
    }
}
