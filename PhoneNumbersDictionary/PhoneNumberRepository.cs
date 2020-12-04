using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class PhoneNumberRepository
    {
        private readonly SqlConnection _conn;

        public PhoneNumberRepository(SqlConnection conn)
        {
            _conn = conn;
        }

        public int Add(PhoneNumber phone)
        {
            string query;
            query = String.Format("INSERT INTO PhoneNumber (PhoneNumber,Name,OrganizationId)  VALUES ('{0}','{1}',{2})", phone.PhoneNumberstr, phone.Name, phone.OrganizaionId);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }
    }
}
