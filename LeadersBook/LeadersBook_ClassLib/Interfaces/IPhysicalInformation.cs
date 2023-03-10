using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IPhysicalInformation<T,U,V> : IModel_OneToOne<T, U, V>
    {
        decimal? Weight { get; set; }
        decimal? Height { get; set; }
        string? Hair { get; set; }
        string? Eyes { get; set; }
        int? Age { get; set; }
        string? BloodType { get; set; }
    }
}
