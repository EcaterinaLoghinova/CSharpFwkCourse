using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class ConsoleOutput : IOutput {

        public void Write(string text){
            Console.Write(text);
        }

        public void WriteLine(string text){
            Console.WriteLine(text);
        }

        public void WriteInfo() {
            Console.WriteLine(" Set playback to Mobile...");
            Console.WriteLine(" Play sound in Mobile:");
        }
    }
}
