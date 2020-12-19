using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneNumbersDictionary;
using System.Data.SqlClient;
using Xunit;

namespace DbTest1
{

    public class DbTest
    {
        [Fact]
        public void ComplexTestDatabase()
        {
            Db db = new Db();
            SqlConnection conn =  db.GetConnection();
            int orgsBefore = GetRowsNumber("Organization", conn);
            int phonesBefore = GetRowsNumber("PhoneNumber", conn);
            int infosBefore = GetRowsNumber("AdditionalInfo", conn);
            int filessBefore = GetRowsNumber("OrganizationFile", conn);//Смотрим сколько было записей

            int cnt_orgs = 10;
            int cnt_items = 5;
            List<Organization> orgs = AddOrganizations(cnt_orgs, cnt_items, db);

            int orgsAfter = GetRowsNumber("Organization", conn);
            int phonesAfter = GetRowsNumber("PhoneNumber", conn);
            int infosAfter = GetRowsNumber("AdditionalInfo", conn);
            int filessAfter = GetRowsNumber("OrganizationFile", conn);

            Assert.Equal(orgsAfter, orgsBefore + cnt_orgs);
            Assert.Equal(phonesAfter, phonesBefore + cnt_orgs* cnt_items);
            Assert.Equal(infosAfter, infosBefore + cnt_orgs * cnt_items);
            Assert.Equal(filessAfter, filessBefore + cnt_orgs * cnt_items);//Проверяем всё ли добавилось



            foreach (Organization org in orgs)//Проверяем, что добавилось то, что мы хотели добавить
            {
                Organization tmp = db.OrganizationRepository.GetById(org.Id);

                db.LoadOrganizationData(tmp);
                Assert.Equal(tmp.Id, org.Id);
                Assert.Equal(tmp.Name, org.Name);
                Assert.Equal(tmp.Location, org.Location);
                Assert.Equal(tmp.Profile, org.Profile);

                Assert.Equal(tmp.PhoneNumbers.Count, org.PhoneNumbersToAdd.Count);
                Assert.Equal(tmp.AdditionalInfos.Count, org.AdditionalInfosToAdd.Count);
                Assert.Equal(tmp.OrganizationFiles.Count, org.OrganizationFilesToAdd.Count);

                for (int i = 0; i < tmp.PhoneNumbers.Count; i++)
                {
                    PhoneNumber phone1 = tmp.PhoneNumbers[i];
                    PhoneNumber phone2 = org.PhoneNumbersToAdd[i];
                    Assert.Equal(phone1.Name, phone2.Name);
                    Assert.Equal(phone1.PhoneNumberstr, phone2.PhoneNumberstr);
                    Assert.Equal(phone1.OrganizaionId, phone2.OrganizaionId);
                }

                for (int i = 0; i < tmp.AdditionalInfos.Count; i++)
                {
                   AdditionalInfo info1 = tmp.AdditionalInfos[i];
                   AdditionalInfo info2 = org.AdditionalInfosToAdd[i];
                   Assert.Equal(info1.InfoData, info2.InfoData);
                   Assert.Equal(info1.InfoType, info2.InfoType);
                   Assert.Equal(info1.OrganizaionId, info2.OrganizaionId);
                }

                for (int i = 0; i < tmp.OrganizationFiles.Count; i++)
                {
                    OrganizationFile file1 = tmp.OrganizationFiles[i];
                    OrganizationFile file2 = org.OrganizationFilesToAdd[i];
                    Assert.Equal(file1.Name, file2.Name);
                    Assert.Equal(file1.Path, file2.Path);
                    Assert.Equal(file1.OrganizaionId, file2.OrganizaionId);
                    
                }
            }




            foreach (Organization org in orgs)
            {
                db.RemoveOrganization(org);
            }


            orgsAfter = GetRowsNumber("Organization", conn);
            phonesAfter = GetRowsNumber("PhoneNumber", conn);
            infosAfter = GetRowsNumber("AdditionalInfo", conn);
            filessAfter = GetRowsNumber("OrganizationFile", conn);


            Assert.Equal(orgsAfter, orgsBefore);
            Assert.Equal(phonesAfter, phonesBefore);
            Assert.Equal(infosAfter, infosBefore);
            Assert.Equal(filessAfter, filessBefore);//Проверяем всё ли удалилось

        }


        private int GetRowsNumber(string table, SqlConnection conn)
        {
            string query = "SELECT COUNT(*) FROM " + table;
            SqlCommand cmd = new SqlCommand(query, conn);
            return (int)cmd.ExecuteScalar();
        }

        public List<Organization> AddOrganizations(int cnt_organizations, int cnt_items, Db db)
        {
            List<Organization> orgs = new List<Organization>();
            for (int j = 1; j <= cnt_organizations; j++)
            {
                Organization org = new Organization();
                org.Name = "Test Organization " + j;
                org.Location = "test Location " + j;
                org.Profile = "Test Profile " + j;

                for (int i = 0; i < cnt_items; i++)
                {
                    PhoneNumber phone = new PhoneNumber();
                    phone.Name = "Test Phone " + i + " " + j;
                    phone.PhoneNumberstr = "+712345" + i + " " + j;
                    org.PhoneNumbersToAdd.Add(phone);
                }

                for (int i = 0; i < cnt_items; i++)
                {
                    AdditionalInfo info = new AdditionalInfo();
                    info.InfoData = "Test data " + i + " " + j;
                    info.InfoType = "Test Type " + i + " " + j;
                    org.AdditionalInfosToAdd.Add(info);
                }

                for (int i = 0; i < cnt_items; i++)
                {
                    OrganizationFile file = new OrganizationFile();
                    file.Name = "test file name " + i + " " + j;
                    file.Path = "test file path " + i + " " + j;
                    org.OrganizationFilesToAdd.Add(file);
                }

                org.Id =  db.AddOrganization(org);
                orgs.Add(org);
            }

            return orgs;
        }

    }
}
