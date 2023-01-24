using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IWeaponInformation<T,U,V> : IModel_OneToOne<T,U,V>
    {
        string WeaponsNumber { get; set; }
        /// <summary>
        /// Weapon Serial Number
        /// </summary>
        string SN { get; set; }
    }
}
