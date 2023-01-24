using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface ICounseling<T,U, V> : IModel_OneToOne<T,U,V>
    {
        ISoldier<T,U>? Soldier { get; set; }
        DateTime? InitialCounselingDate { get; set; }
        DateTime? PerformanceCounselingDate { get; set; }
        DateTime? NextPerformanceCounselingDate { get; set; }
    }
}
