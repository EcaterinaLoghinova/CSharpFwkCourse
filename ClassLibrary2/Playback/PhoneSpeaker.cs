using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class PhoneSpeaker : IPlayback  {
        private IOutput Output;

        public PhoneSpeaker (IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.Write(nameof(PhoneSpeaker));
        }
    }
}
