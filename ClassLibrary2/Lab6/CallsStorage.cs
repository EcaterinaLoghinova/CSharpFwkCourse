using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class CallsStorage : Call
    {
        public static List<List<string>> callLog = new List<List<string>>();
        public static List<Call> callsList = new List<Call>();
        private static List<string> timeStamps = new List<string>();

        public static void AddCall(Call newCall)
        {
            if (callsList.Count!=0 && callsList[0].Equals(newCall))
            {
                //for existing calls update only log with a new timestamp
                timeStamps.Add(newCall.callTimeDate.ToString());
                callLog[0] = timeStamps;
            }
            else
            {   
                callsList.Add(newCall);
                callsList.Sort();
                //for new (different) call create new record in the call log
                timeStamps = new List<string>() {callsList[0].callTimeDate.ToString() };
                callLog.Insert(0, timeStamps);
            }

        }

        public static void RemoveCall(int index)
        {
            callsList.RemoveAt(index);
            callLog.RemoveAt(index);
        }
    }
}
