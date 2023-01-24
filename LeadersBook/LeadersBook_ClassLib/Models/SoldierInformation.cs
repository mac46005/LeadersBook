using LeadersBook_ClassLib.Enums;
using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class SoldierInformation : ISoldierInformation<int, int, ISoldier<int, int>>
    {
        public string? UnitName { get; set; }
        public Rank? Rank { get;set; }
        public DateTime? DOR { get;set; }
        public DateTime? ETS { get;set; }
        public DateTime? BASD { get;set; }
        public string? MOS { get;set; }
        public decimal? TIS { get;set; }
        public decimal? TIG { get;set; }
        public bool? Promotable { get;set; }
        public decimal? Points { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
