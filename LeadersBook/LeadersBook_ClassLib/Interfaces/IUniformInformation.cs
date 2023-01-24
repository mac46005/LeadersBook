using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IUniformInformation<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string CoatSize { get; set; }
        string TrouserSize { get; set; }
        string HatSize { get; set; }
        string BootSize { get; set; }
    }
}
