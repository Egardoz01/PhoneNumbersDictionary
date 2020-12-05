using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{

  
    public  class OrganizationFilterByData: IOrganizationFilter
    {
        public string orgName;
        public bool orgNameComplete;
        public string orgLocation;
        public  bool orgLocationComplete;
        public  string orgProfile;
        public  bool orgProfileComplete;
        public string GetQuery()
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
