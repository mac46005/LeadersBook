using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    internal interface INCO<T,U> : ISoldier<T,U>
    {
        List<ISoldier<T,U>>? Soldiers { get; set; }
        List<IDailyPersonelStatus<T,U,INCO<T,U>>>? ListPersonelStatus { get; set; }
        List<ICounseling<T,U,INCO<T,U>>>? Counselings { get; set; }
        List<INCOER<T,U,INCO<T,U>>>? NCOERs { get; set; }
    }
}
