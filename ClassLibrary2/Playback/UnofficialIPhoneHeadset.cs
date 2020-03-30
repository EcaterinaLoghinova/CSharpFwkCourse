using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class UnofficialIPhoneHeadset : IPlayback {
        private IOutput Output;

        public UnofficialIPhoneHeadset (IOutput output) {
            Output = output;
        }

        public void Play(object data) {
            Output.Write(nameof(UnofficialIPhoneHeadset));
        }

    }
}
