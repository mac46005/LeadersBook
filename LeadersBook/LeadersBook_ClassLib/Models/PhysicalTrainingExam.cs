using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class PhysicalTrainingExam : IPhysicalTrainingExam<int, int, ISoldier<int, int>>
    {
        public decimal? Score => throw new NotImplementedException();

        public List<decimal>? Scores { get; set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
        public DateTime? ExamDate { get;set; }
    }
}
