using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class PhysicalInformation : IPhysicalInformation<int, int, ISoldier<int, int>>
    {
        public decimal? Weight { get; set; }
        public decimal? Height { get;set; }
        public string? Hair { get;set; }
        public string? Eyes { get;set; }
        public int? Age { get;set; }
        public string? BloodType { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
