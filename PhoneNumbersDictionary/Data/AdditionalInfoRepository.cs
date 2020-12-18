using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class AdditionalInfoRepository
    {

        private readonly SqlConnection _conn;

        public AdditionalInfoRepository(SqlConnection conn)
        {
            _conn = conn;
        }

        public int Add(AdditionalInfo info)
        {
            string query;
            query = String.Format("INSERT INTO AdditionalInfo (InfoType,InfoData,OrganizationId)  VALUES ('{0}','{1}',{2})", info.InfoType, info.InfoData, info.OrganizaionId);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }


        public int Edit(AdditionalInfo info)
        {
            string query;
            query = String.Format("UPDATE AdditionalInfo SET InfoType ='{0}', InfoData = '{1}' WHERE Id={2}", info.InfoType, info.InfoData, info.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public int Remove(AdditionalInfo info)
        {
            string query;
            query = String.Format("DELETE FROM AdditionalInfo  WHERE Id={0}", info.Id);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }

        public List<AdditionalInfo> GetAdditionalInfosByOrganizationId(int id)
        {
            List<AdditionalInfo> infos= new List<AdditionalInfo>();

            string query = "SELECT * FROM AdditionalInfo where OrganizationId=" + id;
            SqlCommand cmd = new SqlCommand(query, _conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                AdditionalInfo info = new AdditionalInfo(reader);
                infos.Add(info);
            }

            return infos;
        }

        public void RemoveByOrganizationId(int Id)
        {
            string query = "DELETE FROM AdditionalInfo WHERE OrganizationId=" + Id;
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
        }
    }
}
