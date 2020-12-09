using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class OrganizationFilterByPhone: IOrganizationFilter
    {
        public string PhoneNumber { get; set; }
        public bool CompleteMatch { get; set; }
        public bool IncludeOldNumbers { get; set; }

        public string GetQuery()
        {
            string query = "SELECT DISTINCT Organization.Id, Organization.Name, Organization.Location, Organization.Profile, Organization.Photo FROM Organization,PhoneNumber WHERE Organization.Id = PhoneNumber.OrganizationId AND PhoneNumber.PhoneNumber ";
            if (CompleteMatch)
                query += "= '" + PhoneNumber + "' ";
            else
                query += "LIKE '%" + PhoneNumber + "%' ";

            if (!IncludeOldNumbers)
                query += "AND PhoneNumber.Active=1";
            return query;
        }
    }
}
