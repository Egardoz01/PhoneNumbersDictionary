using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumbersDictionary
{
    class Db
    {
        public SqlConnection _conn { get; private set; }
        public OrganizationRepository OrganizationRepository { get; private set; }
        public PhoneNumberRepository PhoneNumberRepository { get; private set; }

        public AdditionalInfoRepository AdditionalInfoRepository { get; private set; }
        public Db()
        {
            GetConnection();
            OrganizationRepository = new OrganizationRepository(_conn);
            PhoneNumberRepository = new PhoneNumberRepository(_conn);
            AdditionalInfoRepository = new AdditionalInfoRepository(_conn);
        }
        private static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=D:\Documents\Visual Studio 2019\Projects\PhoneNumbersDictionary\PhoneNumbersDictionary\PhoneNumbersDictionary.mdf; Initial Catalog = PhoneNumbersDictionary;  Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;MultipleActiveResultSets=True;";
        }

        public SqlConnection GetConnection()
        {
            if (_conn != null)
            {
                return _conn;
            }

            string sConnection = GetConnectionString();
            _conn = new SqlConnection(sConnection);
            try
            {
                _conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Db connection Exception: " + ex.Message);
            }
            return _conn;

        }

        public void AddOrganization(Organization org)
        {
            int id = OrganizationRepository.Add(org);

            foreach (var phone in org.PhoneNumbersToAdd)
            {
                phone.OrganizaionId = id;
                PhoneNumberRepository.Add(phone);
            }

            foreach (var info in org.AdditionaInfosToAdd)
            {
                info.OrganizaionId = id;
                AdditionalInfoRepository.Add(info);
            }
        }


    }
}
