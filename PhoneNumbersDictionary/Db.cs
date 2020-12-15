using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumbersDictionary
{
    public class Db
    {
        public SqlConnection _conn { get; private set; }
        public OrganizationRepository OrganizationRepository { get; private set; }
        public PhoneNumberRepository PhoneNumberRepository { get; private set; }
        public OrganizationFilesRepositiry OrganizationFilesRepositiry { get; private set; }
        public AdditionalInfoRepository AdditionalInfoRepository { get; private set; }
        public Db()
        {
            GetConnection();
            OrganizationRepository = new OrganizationRepository(_conn);
            PhoneNumberRepository = new PhoneNumberRepository(_conn);
            AdditionalInfoRepository = new AdditionalInfoRepository(_conn);
            OrganizationFilesRepositiry = new OrganizationFilesRepositiry(_conn);
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
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
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

            foreach (var info in org.AdditionalInfosToAdd)
            {
                info.OrganizaionId = id;
                AdditionalInfoRepository.Add(info);
            }

            foreach (var file in org.OrganizationFilesToAdd)
            {
                file.OrganizaionId = id;
                OrganizationFilesRepositiry.Add(file);
            }
        }

        public void EditOrganization(Organization org)
        {
            OrganizationRepository.Edit(org);
            int id = org.Id;
            foreach (var phone in org.PhoneNumbersToAdd)
            {
                phone.OrganizaionId = id;
                PhoneNumberRepository.Add(phone);
            }

            foreach (var phone in org.PhoneNumbersToEdit)
            {
                PhoneNumberRepository.Edit(phone);
            }

            foreach (var phone in org.PhoneNumbersToRemove)
            {
                PhoneNumberRepository.Remove(phone);
            }


            foreach (var info in org.AdditionalInfosToAdd)
            {
                info.OrganizaionId = id;
                AdditionalInfoRepository.Add(info);
            }

            foreach (var info in org.AdditionalInfosToEdit)
            {
                AdditionalInfoRepository.Edit(info);
            }

            foreach (var info in org.AdditionalInfosToRemove)
            {
                AdditionalInfoRepository.Remove(info);
            }

            foreach (var file in org.OrganizationFilesToAdd)
            {
                file.OrganizaionId = id;
                OrganizationFilesRepositiry.Add(file);
            }

            foreach (var file in org.OrganizationFilesToRemove)
            {

                deleteFile(file.Path);
                OrganizationFilesRepositiry.Remove(file);

            }

        }


        public List<Organization> GetOrganizations(IOrganizationFilter filter, int offset=0,  int limit=100)
        {
            List<Organization> orgs = OrganizationRepository.GetOrganizations(filter.GetSelectQuery() + " ORDER BY Id  OFFSET "+ offset + " ROWS FETCH NEXT "+limit+" ROWS ONLY;");

            return orgs;
        }

        public int GetOrganizationsCount(IOrganizationFilter filter)
        {
            SqlCommand cmd = new SqlCommand(filter.GetCountQuery(), _conn);

            return (int)cmd.ExecuteScalar();
        }

        public void LoadOrganizationData(Organization org)
        {
            org.PhoneNumbers = PhoneNumberRepository.GetPhoneNumbersByOrganizationId(org.Id);
            org.AdditionalInfos = AdditionalInfoRepository.GetAdditionalInfosByOrganizationId(org.Id);
            org.OrganizationFiles = OrganizationFilesRepositiry.GetFilesByOrganizationId(org.Id);
        }

        public string copyFileLocally(Organization org, string path)
        {
            try
            {
                string newPath;
                newPath = Directory.GetCurrentDirectory();

                newPath = Path.Combine(newPath, "Files");
                if (!Directory.Exists(newPath))
                    Directory.CreateDirectory(newPath);
                newPath = Path.Combine(newPath, org.Id.ToString());
                if (!Directory.Exists(newPath))
                    Directory.CreateDirectory(newPath);
                newPath = Path.Combine(newPath, Guid.NewGuid().ToString()+ Path.GetExtension(path));
                File.Copy(path, newPath);
                return newPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при копировании файла " + ex.Message);
            }
            return "";
        }

        public void deleteFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка при удалени файла "+ ex.Message);
                }
            }
            
        }


        public void RemoveOrganization(Organization org)
        {
            string query = "DELETE FROM PhoneNumber where OrganizationId=" + org.Id;
            SqlCommand cmd = new SqlCommand(query,_conn);
            cmd.ExecuteNonQuery();
           
            query = "DELETE FROM AdditionalInfo where OrganizationId=" + org.Id;
            cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();

            query = "DELETE FROM OrganizationFile where OrganizationId=" + org.Id;
            cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();

            query = "DELETE FROM Organization where Id=" + org.Id;
            cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();

        }

    }
}
