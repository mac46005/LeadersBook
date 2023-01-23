using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IPhoneNumber
    {
        string Number { get; set; }
        string PhoneType { get; set; }
    }
}
