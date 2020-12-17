using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class OrganizationFilerByFile:IOrganizationFilter
    {
        public string Filename;
        public bool FilenameCompleteMatch;

        public string GetCountQuery()
        {
            return "SELECT COUNT(DISTINCT Organization.id)  " + GetQuery();
        }

        public string GetQuery()
        {
            string query = "FROM OrganizationFile,  Organization WHERE Organization.Id = OrganizationFile.OrganizationId AND OrganizationFile.Name ";

            if (FilenameCompleteMatch)
                query += "= '" + Filename + "'";
            else
                query += "LIKE '%" + Filename + "%'";


            return query;
        }

        public string GetSelectQuery()
        {
            return "SELECT DISTINCT Organization.Id, Organization.Name, Organization.Location, Organization.Profile, Organization.Photo " + GetQuery();
        }
    }
}
