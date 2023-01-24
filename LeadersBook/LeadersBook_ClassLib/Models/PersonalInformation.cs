using LeadersBook_ClassLib.Enums;
using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class PersonalInformation : IPersonalInformation<int, int, ISoldier<int, int>>
    {
        public string? SSN { get; set; }
        public MaritalStatus? MaritalStatus { get;set; }
        public IPerson<int, int, ISoldier<int, int>>? Spouse { get;set; }
        public List<IPerson<int, int, ISoldier<int, int>>>? Children { get;set; }
        public string? Religion { get;set; }
        public string? NextOfKin { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
