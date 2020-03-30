using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class FakeOutput : IOutput{
        private string Text;

        public void Write(string text){
            Text = text;
        }

        public string GetText() {
            return Text;
        }

        public void WriteLine(string text)
        {
        }

        public void WriteInfo() {
        }

    }
}
