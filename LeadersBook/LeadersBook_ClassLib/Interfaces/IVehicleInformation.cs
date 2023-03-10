using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IVehicleInformation<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string? Make { get; set; }
        string? Model { get; set; }
        string? Year { get; set; }
        string? Color { get; set; }
        string? Lic_Plate { get; set; }
    }
}
