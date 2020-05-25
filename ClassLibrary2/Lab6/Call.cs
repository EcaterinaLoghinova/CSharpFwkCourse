using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Framework
{
    public class Call : IComparable<Call>
    {
        public int callId { get; set; }
        public Contact contact { get; set; }
        public DateTime callTimeDate { get; set; }
        public string Direction { get; set; }

        public int CompareTo(Call newCall) {
            var value = 0;

            if (this.callTimeDate < newCall.callTimeDate)
                value = 1;
            if (this.callTimeDate > newCall.callTimeDate)
                value = -1;

            return value;
        }

        public override bool Equals(Object obj)
        {
            var newCall = obj as Call;
            // If parameter is null return false.
            if (newCall == null)
            {
                return false;
            }

            return contact.Equals(newCall.contact)&&Direction.Equals(newCall.Direction);
        }

        public override int GetHashCode()
        {
            return this.contact.GetHashCode();
        }

    }
}
