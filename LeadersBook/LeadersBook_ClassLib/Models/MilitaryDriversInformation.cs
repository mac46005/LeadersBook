using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class MilitaryDriversInformation : IMilitaryDriversInformation<int, int, ISoldier<int, int>>
    {
        public DateTime? Date_CTT_Test { get; set; }
        public bool? PassedExam { get;set; }
        public DateTime? Date_Drivers_Training { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
