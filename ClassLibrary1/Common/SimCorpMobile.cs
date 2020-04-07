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
        //Screen
        private readonly OLEDScreen vOLEDScreen;
        private readonly ColorfulScreen vColorScreen;
        private iPhoneHeadset iphoneHeadset;
        private SamsungHeadset samsungHeadset;
        private UnofficialIPhoneHeadset unofficialiPhoneHeadset;
        private PhoneSpeaker phoneSpeaker;
        private List<IPlayback> objectlist;

        //Playback
        private ConsoleOutput Output;

        public SimCorpMobile()
        {
            mobileModel = new Model(1, "SimCorp model");
            vOLEDScreen = new OLEDScreen();
            vColorScreen = new ColorfulScreen(255, 255, 255);
            rgb = "";
            Output = new ConsoleOutput();
            iphoneHeadset = new iPhoneHeadset(Output);
            samsungHeadset = new SamsungHeadset(Output);
            unofficialiPhoneHeadset = new UnofficialIPhoneHeadset(Output);
            phoneSpeaker = new PhoneSpeaker(Output);
            objectlist = new List<IPlayback>() { iphoneHeadset, samsungHeadset, unofficialiPhoneHeadset, phoneSpeaker };
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

        //Handle selected playback option
        public void WriteSelectedOption(int answer){
            switch (answer)
            {
                case 1:         
                    PlaybackInfo(objectlist[0]);
                    break;
                case 2:
                    PlaybackInfo(objectlist[1]);
                    break;
                case 3:
                    PlaybackInfo(objectlist[2]);
                    break;
                case 4:
                    PlaybackInfo(objectlist[3]);
                    break;
                default:
                    Console.WriteLine("Unknown option has been selected.");
                    Console.WriteLine("Please try again.");
                    WritePlaybackOptions(objectlist);
                    break;
            }
        }

        //Playback options to select
        public void SelectPlaybackOption(){
            WritePlaybackOptions(objectlist);
            int answer = int.Parse(Console.ReadLine());
            WriteSelectedOption(answer);       
        }
    }
}       