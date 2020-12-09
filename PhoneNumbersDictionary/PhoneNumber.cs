using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumberstr { get; set; }

        public int OrganizaionId { get; set; }

        public override string ToString()
        {
            return Name+": "+PhoneNumberstr;
        }
        public PhoneNumber()
        { 
        }

        public PhoneNumber(PhoneNumber phone)
        {
            Id = phone.Id;
            Name = phone.Name;
            PhoneNumberstr = phone.PhoneNumberstr;
            OrganizaionId = phone.OrganizaionId;
        }
        public PhoneNumber(SqlDataReader reader) 
        {
            Id = (int)reader["Id"];
            Name = (string)reader["Name"];
            PhoneNumberstr = (string)reader["PhoneNumber"];
            OrganizaionId = (int)reader["OrganizationId"];
        }
    }
}
