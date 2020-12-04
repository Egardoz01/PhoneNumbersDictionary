using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumberstr { get; set; }

        public int OrganizaionId { get; set; }

        public override string ToString()
        {
            return Name+": "+PhoneNumberstr;
        }
    }
}
