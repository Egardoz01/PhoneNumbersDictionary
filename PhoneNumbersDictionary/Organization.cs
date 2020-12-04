using System;
using System.Collections.Generic;
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

        public List<PhoneNumber> PhoneNumbersToAdd { get; set; }

        public List<PhoneNumber> PhoneNumbersToEdit{ get; set; }

        public List<PhoneNumber> PhoneNumbersToRemove { get; set; }

        public List<AdditionaInfo> AdditionaInfosToAdd { get; set; }

        public List<AdditionaInfo> AdditionaInfosToEdit { get; set; }

        public List<AdditionaInfo> AdditionaInfosRemove { get; set; }

        public Organization()
        {
            PhoneNumbersToAdd = new List<PhoneNumber>();
            PhoneNumbersToEdit = new List<PhoneNumber>();
            PhoneNumbersToRemove = new List<PhoneNumber>();
            AdditionaInfosToAdd = new List<AdditionaInfo>();
            AdditionaInfosRemove = new List<AdditionaInfo>();
            AdditionaInfosToEdit = new List<AdditionaInfo>();
        }
    }
}
