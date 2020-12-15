using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class AdditionalInfo
    {
        public int Id { get; set; }
        public string InfoType { get; set; }
        public string InfoData { get; set; }
        public int OrganizaionId { get; set; }

        public override string ToString()
        {
            return InfoType + ": " + InfoData;
        }
        public AdditionalInfo()
        { 
        }

        public AdditionalInfo(AdditionalInfo info)
        {
            Id = info.Id;
            InfoData = info.InfoData;
            InfoType = info.InfoType;
            OrganizaionId = info.OrganizaionId;
        }
        public AdditionalInfo(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            InfoType = (string)reader["InfoType"];
            InfoData = (string)reader["InfoData"];
            OrganizaionId = (int)reader["OrganizationId"];
        }
    }
}

