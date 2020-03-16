using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class ColorfulScreen : ScreenBase {

        private string screenType;
        private int tonesOfR;
        private int tonesOfG;
        private int tonesOfB;
        public ColorfulScreen(int R, int G, int B)
        {
            screenType = "Colorful Screen";
            tonesOfR = R;
            tonesOfG = G;
            tonesOfB = B;
        }

        public ColorfulScreen(){
            screenType = "Colorful Screen";
        }

        public int GetTonesR() {return tonesOfR;}
        public int GetTonesG() {return tonesOfG;}
        public int GetTonesB() {return tonesOfB;}

        public override void Show(IScreenImage screenImage) { 
            //here code that draws colorful image could be added
        }

        public override void Show(IScreenImage screenImage, int brightness){
            //brighness parameter can be used here
        }
        public override string ToString()
        {
            return screenType;
        }
    }
}
