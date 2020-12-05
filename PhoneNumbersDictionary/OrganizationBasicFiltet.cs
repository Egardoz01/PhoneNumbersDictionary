using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class OrganizationBasicFiltet :IOrganizationFilter
    {

        public string GetQuery()
        {
            return "SELECT * FROM Organization";
        }
    }
}
