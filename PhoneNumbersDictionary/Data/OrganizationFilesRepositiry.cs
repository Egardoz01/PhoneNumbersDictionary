using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class OrganizationFilesRepositiry
    {
        private readonly SqlConnection _conn;

        public OrganizationFilesRepositiry(SqlConnection conn)
        {
            _conn = conn;
        }

        public int Add(OrganizationFile file)
        {
            string query;
            query = String.Format("INSERT INTO OrganizationFile (Path,Name,OrganizationId)  VALUES ('{0}','{1}',{2})", file.Path, file.Name, file.OrganizaionId);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public int Remove(OrganizationFile file)
        {
            string query;
            query = String.Format("DELETE FROM OrganizationFile  WHERE Id={0}", file.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public List<OrganizationFile> GetFilesByOrganizationId(int id)
        {
            List<OrganizationFile> files = new List<OrganizationFile>();

            string query = "SELECT * FROM OrganizationFile WHERE OrganizationId=" + id;
            SqlCommand cmd = new SqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrganizationFile phone = new OrganizationFile(reader);
                files.Add(phone);
            }

            return files;
        }
    }
}
