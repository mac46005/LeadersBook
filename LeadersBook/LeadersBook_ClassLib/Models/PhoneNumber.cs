using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadersBook_ClassLib.Interfaces;

namespace LeadersBook_ClassLib.Models
{
    public class PhoneNumber : IPhoneNumber<int, int, ISoldier<int, int>>
    {
        public string? Number { get; set; }
        public string? PhoneType { get; set; }
        public int Model_ID { get; set; }
        public int ID { get; set; }
    }
}
