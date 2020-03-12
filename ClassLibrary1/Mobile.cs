using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class Mobile {
        public abstract ScreenBase Screen {get; }
        public abstract ScreenBase ScreenColor { get; }
        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
            ScreenColor.Show(screenImage);
        }

        private SelfieCamera selfieCamera = new SelfieCamera();

        public string GetDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("Phone information:");
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Screen Color: {ScreenColor.ToString()}");
            descriptionBuilder.AppendLine($"Video on selfie camera: {selfieCamera.HasVideo(true)}");
            return descriptionBuilder.ToString();
        }
    }
}
