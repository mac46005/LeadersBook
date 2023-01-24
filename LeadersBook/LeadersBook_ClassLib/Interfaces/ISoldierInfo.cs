using DbManipulation_ClassLib.Interfaces;
using LeadersBook_ClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface ISoldierInfo<T,U,V> : IModel_OneToOne<T,U, V>
    {
        string? UnitName { get; set; }
        Rank? Rank { get; set; }
        /// <summary>
        /// Date of rank
        /// </summary>
        DateTime? DOR { get; set; }
        /// <summary>
        /// Expiration term of service
        /// </summary>
        DateTime? ETS { get; set; }
        /// <summary>
        /// Basic active service date
        /// </summary>
        DateTime? BASD { get; set; }
        /// <summary>
        /// Military occupational specialty
        /// </summary>
        string? MOS { get; set; }
        /// <summary>
        /// Total time in which someone is in the Army
        /// </summary>
        decimal? TIS { get; set; }
        /// <summary>
        /// Number of months or years in which an officer serves in a given rank
        /// </summary>
        decimal? TIG { get; set; }
        bool? Promotable { get; set; }
        decimal? Points { get; set; }


    }
}
