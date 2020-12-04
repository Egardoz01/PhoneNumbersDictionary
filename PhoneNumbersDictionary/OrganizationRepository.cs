using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PhoneNumbersDictionary
{
    class OrganizationRepository
    {
        private readonly SqlConnection _conn;

        public OrganizationRepository(SqlConnection conn)
        {
            _conn = conn;
        }

        public int Add(Organization org)
        {
            string query;
            query = String.Format("INSERT INTO Organization (Name,Location,Profile) output INSERTED.ID VALUES ('{0}','{1}','{2}')", org.Name,org.Location,org.Profile);

            SqlCommand cmd = new SqlCommand(query,_conn);

            return (int)cmd.ExecuteScalar();
        }

    }
}
