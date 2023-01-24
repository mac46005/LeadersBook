using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Remarks : IRemarks<int, int, ISoldier<int, int>>
    {
        public string? Remark { get; set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
