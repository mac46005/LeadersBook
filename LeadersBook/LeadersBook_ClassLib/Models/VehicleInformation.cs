using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class VehicleInformation : IVehicleInformation<int, int, ISoldier<int, int>>
    {
        public string? Make { get; set; }
        public string? Model { get;set; }
        public string? Year { get;set; }
        public string? Color { get;set; }
        public string? Lic_Plate { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
