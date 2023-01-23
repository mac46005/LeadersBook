using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IContactInformation
    {
        List<IAddress> Addresses { get; set; }
        List<IPhoneNumber> PhoneNumbers { get; set; }
    }
}
