using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class PhoneNumberRepository
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

        public int Edit(PhoneNumber phone)
        {
            string query;
            query = String.Format("UPDATE PhoneNumber SET PhoneNumber ='{0}', Name = '{1}' WHERE Id={2}", phone.PhoneNumberstr, phone.Name, phone.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public int Remove(PhoneNumber phone)
        {
            string query;
            query = String.Format("DELETE FROM PhoneNumber  WHERE Id={0}", phone.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public List<PhoneNumber> GetPhoneNumbersByOrganizationId(int id)
        {
            List<PhoneNumber> phones = new List<PhoneNumber>();

            string query = "SELECT * FROM PhoneNumber where OrganizationId="+id;
            SqlCommand cmd = new SqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PhoneNumber phone = new PhoneNumber(reader);
                phones.Add(phone);
            }

            return phones;
        }
    }
}
