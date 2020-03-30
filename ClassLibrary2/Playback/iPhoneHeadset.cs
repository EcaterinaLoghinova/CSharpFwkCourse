using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class iPhoneHeadset : IPlayback {
        private IOutput Output;

        public iPhoneHeadset (IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.Write(nameof(iPhoneHeadset));
        }

    }
}
