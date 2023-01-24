using DbManipulation_ClassLib.Interfaces;
using LeadersBook_ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IPersonalInformation<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string SSN { get; set; }
        MaritalStatus MaritalStatus { get; set; }
        IPerson<T,U,V> Spouse { get; set; }
        List<IPerson<T,U,V>> Children { get; set; }
        string Religion { get; set; }
        string NextOfKin { get; set; }
    }
}
