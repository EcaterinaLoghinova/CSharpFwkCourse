using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class SimCorpMobile : Mobile
    {
        private Model mobileModel;
        private readonly OLEDScreen vOLEDScreen;
        private readonly ColorfulScreen vColorScreen;

        public SimCorpMobile()
        {
            mobileModel = new Model(1, "SimCorp model");
            vOLEDScreen = new OLEDScreen();
            vColorScreen = new ColorfulScreen(255, 255, 255);
            rgb = "";
        }

        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override ScreenBase ScreenColor { get { return vColorScreen; } }
        public override string ShowModel()
        {
            return mobileModel.GetModel();
        }

        private string r, g, b;
        private string rgb;
        public override string ShowRGB()
        {
            r = vColorScreen.GetTonesR().ToString();
            g = vColorScreen.GetTonesG().ToString();
            b = vColorScreen.GetTonesB().ToString();
            rgb = string.Join(",", r, g, b);
            return rgb;
   
        }
    }
}
        