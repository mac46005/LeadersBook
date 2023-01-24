using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class ServedCrewWeaponInformation : IServedCrewWeaponInformation<int, int, ISoldier<int, int>>
    {
        public string? Type { get; set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
        public DateTime? ExamDate { get;set; }
    }
}
