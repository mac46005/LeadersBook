﻿using DbManipulation_ClassLib.Interfaces;
using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class ContactInformation : IContactInformation<int, int, ISoldier<int, int>>
    {
        public List<IAddress<int, int, ISoldier<int, int>>>? Addresses { get; set; }
        public List<IPhoneNumber<int, int, ISoldier<int, int>>>? PhoneNumbers { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
