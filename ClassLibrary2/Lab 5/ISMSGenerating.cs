using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public interface  ISMSGenerating
    {
       void RunMessageGenerating(int index);
       void StopMessageGenerating();
    }
  }
