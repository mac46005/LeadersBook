using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IMilitaryDriversInformation<T,U,V> : IModel_OneToOne<T,U,V>
    {
        DateTime Date_CTT_Test { get; set; }
        bool PassedExam { get; set; }
        DateTime Date_Drivers_Training { get; set; }

    }
}
