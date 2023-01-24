using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Counseling : ICounseling<int, int, ISoldier<int, int>>
    {
        public ISoldier<int, int>? Soldier { get; set; }
        public DateTime? InitialCounselingDate { get;set; }
        public DateTime? PerformanceCounselingDate { get;set; }
        public DateTime? NextPerformanceCounselingDate { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
