using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface INCO_Information
    {
        DateTime OnlineTrainingCompleted { get; set; }
        DateTime BLC_Completed { get; set; }
        DateTime ALC_Completed { get; set; }
        DateTime Date_Last_NCOER { get; set; }
    }
}
