using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class OrganizationBasicFilter :IOrganizationFilter
    {
        public string GetCountQuery()
        {
            return "SELECT COUNT (*) FROM Organization";
        }

        public string GetQuery()
        {
            return "";
        }

        public string GetSelectQuery()
        {
            return "SELECT * FROM Organization";
        }
    }
}
