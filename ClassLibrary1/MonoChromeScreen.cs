using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class MonochromeScreen : ScreenBase {
        public override void Show(IScreenImage screenImage)
        {
           //here code that draws greyscale image could be added
        }

        public override void Show(IScreenImage screenImage, int brightness){
           //brighness parameter can be used here
        }

        public override string ToString(){
            return "Monochrome Screen";
        }
    }
}
