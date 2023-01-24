using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IContactInformation<T,U,V> : IModel_OneToOne<T, U, V>
    {
        List<IAddress<T,U,V>>? Addresses { get; set; }
        List<IPhoneNumber<T,U,V>>? PhoneNumbers { get; set; }
    }
}
