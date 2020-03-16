using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class MonochromeScreen : ScreenBase {

        private string screenType;
        private int tonesOfGrey;
        public MonochromeScreen(int TonesOfGrey)
        {
            screenType = "Monochrome Screen";
            tonesOfGrey = TonesOfGrey;
        }

        public MonochromeScreen()
        {
            screenType = "Monochrome Screen";
        }

        public override void Show(IScreenImage screenImage)
        {
           //here code that draws greyscale image could be added
        }

        public override void Show(IScreenImage screenImage, int brightness){
           //brighness parameter can be used here
        }

        public override string ToString(){
            return screenType;
        }
    }
}
