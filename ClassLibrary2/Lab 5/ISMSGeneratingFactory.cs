using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public enum GenerateType
    {
        smsGeneratingTask,
        smsGeneratingThread
    }
    public interface ISMSGeneratingFactory
    {
       ISMSGenerating CreateGeneratingType(GenerateType type);
    }
}
