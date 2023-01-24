using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class NCOER : INCOER<int, int, ISoldier<int, int>>
    {
        public ISoldier<int, int>? Solder { get; set; }
        public string? DEROS { get;set; }
        public string? Type { get;set; }
        public DateTime? Last { get;set; }
        public DateTime? Thru { get;set; }
        public string? SUS_To_Company { get;set; }
        public string? Status { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
