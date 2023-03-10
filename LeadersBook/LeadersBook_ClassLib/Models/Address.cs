using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Address : IAddress<int, int, ISoldier<int, int>>
    {
        public string? Street { get; set; }
        public string? City { get;set; }
        public string? State { get;set; }
        public string? PostalCode { get;set; }
        public string? Country { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
