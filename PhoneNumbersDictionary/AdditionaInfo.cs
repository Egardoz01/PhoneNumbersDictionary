using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class AdditionaInfo
    {
        public int Id { get; set; }
        public string InfoType { get; set; }
        public string InfoData { get; set; }
        public int OrganizaionId { get; set; }

        public override string ToString()
        {
            return InfoType + ": " + InfoData;
        }
    }
}

