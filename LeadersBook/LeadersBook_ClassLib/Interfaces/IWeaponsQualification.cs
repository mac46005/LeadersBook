using DbManipulation_ClassLib.Interfaces;
using LeadersBook_ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IWeaponsQualification<T,U,V> : IModel_OneToOne<T,U,V>
    {
        DateTime DateQualified { get; set; }
        string Type { get; set; }
        WeaponsQualificationType Qualification { get; set; }
    }
}
