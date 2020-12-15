using PhoneNumbersDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            Db db = new Db();

            int cnt_organizations = 10;
            int cnt_items = 10;

            int next_step = 10;
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
                    phone.PhoneNumberstr = "+712345";
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

                db.AddOrganization(org);
                if (next_step <= j * 100 / cnt_organizations)
                {
                    Console.WriteLine(next_step + "%  DONE");
                    next_step += 10;

                }
            }
        }
    }
}
