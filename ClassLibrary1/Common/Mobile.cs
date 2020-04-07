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
        private ConsoleOutput output;
       
        public Mobile(){
          selfieCamera = new SelfieCamera();
          descriptionBuilder = new StringBuilder();
          output = new ConsoleOutput();
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

        public IPlayback PlaybackComponent;

        public void WritePlaybackOptions(List<IPlayback> data)
        {
            Console.WriteLine("Select playback component (specify index):");
            for (int i = 0; i < data.Count; i++)
            {
                output.Write($"{i+1} - ");
                data[i].Play(data[i]);
                output.WriteLine("");
            }
        }

        public void PlaybackInfo(IPlayback data)
        {
            PlaybackComponent = data;
            PlaybackComponent.Play(data);
            output.WriteLine(" playback selected");
            output.WriteInfo();
            PlaybackComponent.Play(data);
            output.WriteLine(" sound");
            Console.ReadKey();
        }
    }
}
