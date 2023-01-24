using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IPhysicalTrainingExam<T,U,V> : IModel_OneToOne<T, U ,V>, IExamDate
    {
        decimal Score { get; }
        List<decimal> Scores { get; set; }
    }
}
