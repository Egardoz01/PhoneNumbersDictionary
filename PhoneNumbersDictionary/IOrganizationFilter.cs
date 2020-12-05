using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public interface IOrganizationFilter
    {
        string GetQuery();
    }
}
