using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbersDictionary
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public string Profile { get; set; }

        public string PhotoPath { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

        public List<PhoneNumber> PhoneNumbersToAdd { get; set; }

        public List<PhoneNumber> PhoneNumbersToEdit{ get; set; }

        public List<PhoneNumber> PhoneNumbersToRemove { get; set; }

        public List<AdditionalInfo> AdditionalInfos { get; set; }

        public List<AdditionalInfo> AdditionalInfosToAdd { get; set; }

        public List<AdditionalInfo> AdditionalInfosToEdit { get; set; }

        public List<AdditionalInfo> AdditionalInfosToRemove { get; set; }

        
        public Organization()
        {
            PhoneNumbersToAdd = new List<PhoneNumber>();
            PhoneNumbersToEdit = new List<PhoneNumber>();
            PhoneNumbersToRemove = new List<PhoneNumber>();
            AdditionalInfosToAdd = new List<AdditionalInfo>();
            AdditionalInfosToRemove = new List<AdditionalInfo>();
            AdditionalInfosToEdit = new List<AdditionalInfo>();
        }

        public Organization(SqlDataReader reader) :this()
        {
            Id = (int)reader["Id"];
            Name = (string)reader["Name"];
            Profile = (string)reader["Profile"];
            Location = (string)reader["Location"];
            PhotoPath = (string)reader["Photo"];
        }

        public override string ToString()
        {
            return Name+" - "+Profile;
        }
    }
}
