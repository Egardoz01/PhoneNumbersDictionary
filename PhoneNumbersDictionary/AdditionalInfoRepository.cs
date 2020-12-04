using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    class AdditionalInfoRepository
    {

        private readonly SqlConnection _conn;

        public AdditionalInfoRepository(SqlConnection conn)
        {
            _conn = conn;
        }

        public int Add(AdditionaInfo info)
        {
            string query;
            query = String.Format("INSERT INTO AdditionalInfo (InfoType,InfoData,OrganizationId)  VALUES ('{0}','{1}',{2})", info.InfoType, info.InfoData, info.OrganizaionId);

            SqlCommand cmd = new SqlCommand(query, _conn);

            return cmd.ExecuteNonQuery();
        }
    }
}
