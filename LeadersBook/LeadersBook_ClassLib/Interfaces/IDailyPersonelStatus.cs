using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface IDailyPersonelStatus<T,U, V> : IModel_OneToOne<T, U, V>
    {
        DateTime? Date { get; set; }
        int? OFF_Authorized { get; set; }
        int? NCO_Authorized { get; set; }
        int? ENL_Authorized { get; set; }
        int? OFF_Assigned { get; set; }
        int? NCO_Assigned { get; set; }
        int? ENL_Assigned { get; set; }
        int? OFF_Present { get; set; }
        int? NCO_Present { get; set; }
        int? ENL_Present { get; set; }
        int? OFF_Absent { get; set; }
        int? NCO_Absent { get; set; }
        int? ENL_Absent { get; set; }
        int? TotalAuthorized { get; }
        int? TotalAssigned { get; }
        int? Total_Present_For_Duty { get; }
        int? Total_Absent_From_Duty { get; }

        /// <summary>
        /// Army Temporary Duty
        /// </summary>
        int? TDY { get; set; }
        int? Unsat { get; set; }
        int? PASS { get; set; }
        int? InProcessing { get; set; }
        int? Profile { get; set; }
        int? Appt { get; set; }
        /// <summary>
        /// Killed In Action
        /// </summary>
        int? KIA { get; set; }
        /// <summary>
        /// Missing In Action
        /// </summary>
        int? MIA { get; set; }
        int? Other { get; set; }
        int? OnDuty { get; set; }
        int? OutProcessing { get; set; }
        int? Hospital { get; set; }
        int? ConvLeave { get; set; }
        /// <summary>
        /// Wounded In Action
        /// </summary>
        int? WIA { get; set; }
        /// <summary>
        /// Absent Without Official Leave
        /// </summary>
        int? AWOL { get; set; }
        int? LEAVE { get; set; }
    }
}
