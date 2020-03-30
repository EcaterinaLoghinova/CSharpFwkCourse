using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public interface IOutput  {
        void Write(string text);
        void WriteLine(string text);
        void WriteInfo();
    }
}
