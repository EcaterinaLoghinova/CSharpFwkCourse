using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework.Charger
{
    public class TypeCUSB{
        private IOutput Output;
        public TypeCUSB(IOutput output)
        {
            Output = output;
        }

        public void Charger(object data)
        {
            Output.Write($" {nameof(TypeCUSB)} ");
        }
    }
}
