using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class ContactInformation<T, U, V> : IContactInformation<T, U, V>
    {
        public List<IAddress<T, U, V>>? Addresses { get; set; }
        public List<IPhoneNumber<T, U, V>>? PhoneNumbers { get;set; }
        public U Model_ID { get;set; }
        public T ID { get;set; }
    }
}
