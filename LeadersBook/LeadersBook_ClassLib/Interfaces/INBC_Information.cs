using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface INBC_Information<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string NBC_Suit_Size { get; set; }
        string MarkNumber { get; set; }
        bool InsertRequired { get; set; }
        DateTime Date_NBC_Prof { get; set; }
        string CONF { get; set; }
    }
}
