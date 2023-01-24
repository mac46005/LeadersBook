using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IAddress<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string? Street { get; set; }
        string? City { get; set; }
        string? State { get; set; }
        string? PostalCode { get; set; }
        string? Country { get; set; }
    }
}
