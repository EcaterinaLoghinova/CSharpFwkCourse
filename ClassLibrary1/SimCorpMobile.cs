using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();

        public override ScreenBase ScreenColor { get { return vColorScreen; } }
        private readonly ColorfulScreen vColorScreen = new ColorfulScreen();

    }
}
        