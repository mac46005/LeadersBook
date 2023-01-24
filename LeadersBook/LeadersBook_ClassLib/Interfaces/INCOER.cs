using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface INCOER<T,U,V> : IModel_OneToOne<T,U,V>
    {
        ISoldier<T,U> Solder { get; set; }
        string DEROS { get; set; }
        string Type { get; set; }
        DateTime Last { get; set; }
        DateTime Thru { get; set; }
        string SUS_To_Company { get; set; }
        string Status { get; set; }
    }
}
