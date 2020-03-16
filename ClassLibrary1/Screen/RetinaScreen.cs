using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class RetinaScreen : ColorfulScreen {

        private string screenType;

        public RetinaScreen()
        {
            screenType = "Retina Screen";
        }

        private int dpi;
        public RetinaScreen(int Dpi)
        {
            dpi = Dpi;
            if (dpi > 300)
            { screenType = "Retina screen"; }
            else
            { screenType = "Not Retina screen"; }
        }


        public override void Show(IScreenImage screenImage) {
            //here logic for Retina  screen can be added
        }

        public override string ToString()
        {
           return screenType; 
        }
    }
}
