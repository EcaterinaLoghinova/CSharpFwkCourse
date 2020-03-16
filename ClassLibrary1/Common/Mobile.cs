using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public abstract class Mobile {

        private SelfieCamera selfieCamera;
        private StringBuilder descriptionBuilder;
       
        public Mobile(){
          selfieCamera = new SelfieCamera();
          descriptionBuilder = new StringBuilder();
        }

        public abstract ScreenBase Screen {get; }
        public abstract ScreenBase ScreenColor { get; }
        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
            ScreenColor.Show(screenImage);
        }

        public abstract string ShowModel();
        public abstract string ShowRGB();

        public override string ToString() {
            descriptionBuilder.AppendLine($"Model info: {ShowModel()}");
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Screen Color: {ScreenColor.ToString()}");
            descriptionBuilder.AppendLine($"RGB tones: {ShowRGB()}");
            descriptionBuilder.AppendLine($"Video on selfie camera: {selfieCamera.HasVideo(true)}");
            return descriptionBuilder.ToString();
        }
    }
}
