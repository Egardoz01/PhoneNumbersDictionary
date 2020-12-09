using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PhoneNumbersDictionary
{
    public class OrganizationRepository
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

        public int Edit(Organization org)
        {
            string query;
            query = String.Format("UPDATE Organization SET Name ='{0}', Location = '{1}', Profile = '{2}', Photo='{3}'  WHERE Id={4}", org.Name, org.Location,org.Profile, org.PhotoPath, org.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public List<Organization> GetOrganizations(string query)
        {
            List<Organization> orgs = new List<Organization>();

            SqlCommand cmd = new SqlCommand(query,_conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Organization org = new Organization(reader);
                orgs.Add(org);
            }

            return orgs;
        }

    }
}
