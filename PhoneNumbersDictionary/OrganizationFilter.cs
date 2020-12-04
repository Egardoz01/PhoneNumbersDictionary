using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public static class OrganizationFilter
    {

        public static string GetQuery(string orgName, bool orgNameComplete, string orgLocation, bool orgLocationComplete, string orgProfile,bool orgProfileComplete)
        {
            string query="SELECT * FROM Organization WHERE ";
            query += "Name ";
            if (orgNameComplete)
                query += "='" +orgName +"' ";
            else
                query += "LIKE '%" + orgName + "%' ";
            query += "AND ";

            query += "Location ";
            if (orgLocationComplete)
                query += "='" + orgLocation + "' ";
            else
                query += "LIKE '%" + orgLocation + "%' ";
            query += "AND ";

            query += "Profile ";
            if (orgProfileComplete)
                query += "='" + orgProfile + "' ";
            else
                query += "LIKE '%" + orgProfile + "%' ";
           

            return query;
        }
    }
}
