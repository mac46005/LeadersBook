using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Counseling<T, U, V> : ICounseling<T, U, V>
    {
        public ISoldier<T, U>? Soldier { get; set; }
        public DateTime? InitialCounselingDate { get;set; }
        public DateTime? PerformanceCounselingDate { get;set; }
        public DateTime? NextPerformanceCounselingDate { get;set; }
        public U Model_ID { get;set; }
        public T ID { get;set; }
    }
}
