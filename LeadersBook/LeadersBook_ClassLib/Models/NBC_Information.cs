using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class NBC_Information : INBC_Information<int, int, ISoldier<int, int>>
    {
        public string? NBC_Suit_Size { get; set; }
        public string? MarkNumber { get;set; }
        public bool? InsertRequired { get;set; }
        public DateTime? Date_NBC_Prof { get;set; }
        public string? CONF { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
