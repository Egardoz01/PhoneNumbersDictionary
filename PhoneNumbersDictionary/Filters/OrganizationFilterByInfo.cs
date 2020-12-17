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

        public string GetCountQuery()
        {
            return "SELECT COUNT(DISTINCT Organization.id) " + GetQuery();
        }

        public string GetQuery()
        {
            string query = "FROM Organization,AdditionalInfo WHERE Organization.Id = AdditionalInfo.OrganizationId ";

            if (InfoType != "")
            {
                query += " AND AdditionalInfo.InfoType ";
                if (TypeCompleteMatch)
                    query += "= '" + InfoType + "' ";
                else
                    query += "LIKE '%" + InfoType + "%' ";

               
            }
            if (InfoType != "")
            {
                query += " AND AdditionalInfo.InfoData ";
                if (DataCompleteMatch)
                    query += "= '" + InfoData + "'";
                else
                    query += "LIKE '%" + InfoData + "%'";
            }
            return query;
        }

        public string GetSelectQuery()
        {
            return "SELECT DISTINCT Organization.Id, Organization.Name, Organization.Location, Organization.Profile, Organization.Photo " + GetQuery();
        }
    }
}
