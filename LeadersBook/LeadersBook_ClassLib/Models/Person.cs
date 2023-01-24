using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Person : IPerson<int, int, ISoldier<int, int>>
    {
        public string? FirstName { get; set; }
        public string? LastName { get;set; }
        public DateTime? DOB { get;set; }
        public string? Gender { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
