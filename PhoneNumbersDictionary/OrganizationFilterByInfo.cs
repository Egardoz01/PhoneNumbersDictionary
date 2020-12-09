using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class OrganizationFilterByInfo :IOrganizationFilter
    {
        public string InfoType { get; set; }
        public string InfoData { get; set; }
        public bool TypeCompleteMatch { get; set; }
        public bool DataCompleteMatch { get; set; }

        public string GetQuery()
        {
            string query = "SELECT DISTINCT Organization.Id, Organization.Name, Organization.Location, Organization.Profile FROM Organization,AdditionalInfo WHERE Organization.Id = AdditionalInfo.OrganizationId AND AdditionalInfo.InfoType ";
            if (TypeCompleteMatch)
                query += "= '" + InfoType + "' ";
            else
                query += "LIKE '%" + InfoType + "%' ";

            query += "AND AdditionalInfo.InfoData ";

            if (DataCompleteMatch)
                query += "= '" + InfoData + "'";
            else
                query += "LIKE '%" + InfoData + "%'";

            return query;
        }
    }
}
