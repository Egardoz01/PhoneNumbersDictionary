using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class OrganizationFile
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }

        public int OrganizaionId { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public OrganizationFile()
        {
        }

        public OrganizationFile(OrganizationFile file)
        {
            Id = file.Id;
            Name = file.Name;
            Path = file.Path;
            OrganizaionId = file.OrganizaionId;
        }
        public OrganizationFile(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            Name = (string)reader["Name"];
            Path = (string)reader["Path"];
            OrganizaionId = (int)reader["OrganizationId"];
        }
    }
}
