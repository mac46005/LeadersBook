using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class UniformInformation : IUniformInformation<int, int, ISoldier<int, int>>
    {
        public string? CoatSize { get; set; }
        public string? TrouserSize { get;set; }
        public string? HatSize { get;set; }
        public string? BootSize { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
