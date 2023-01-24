using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class DailyPersonelStatus : IDailyPersonelStatus<int, int, ISoldier<int, int>>
    {
        public DateTime? Date { get; set; }
        public int? OFF_Authorized { get;set; }
        public int? NCO_Authorized { get;set; }
        public int? ENL_Authorized { get;set; }
        public int? OFF_Assigned { get;set; }
        public int? NCO_Assigned { get;set; }
        public int? ENL_Assigned { get;set; }
        public int? OFF_Present { get;set; }
        public int? NCO_Present { get;set; }
        public int? ENL_Present { get;set; }
        public int? OFF_Absent { get;set; }
        public int? NCO_Absent { get;set; }
        public int? ENL_Absent { get;set; }

        public int? TotalAuthorized => throw new NotImplementedException();

        public int? TotalAssigned => throw new NotImplementedException();

        public int? Total_Present_For_Duty => throw new NotImplementedException();

        public int? Total_Absent_From_Duty => throw new NotImplementedException();

        public int? TDY { get;set; }
        public int? Unsat { get;set; }
        public int? PASS { get;set; }
        public int? InProcessing { get;set; }
        public int? Profile { get;set; }
        public int? Appt { get;set; }
        public int? KIA { get;set; }
        public int? MIA { get;set; }
        public int? Other { get;set; }
        public int? OnDuty { get;set; }
        public int? OutProcessing { get;set; }
        public int? Hospital { get;set; }
        public int? ConvLeave { get;set; }
        public int? WIA { get;set; }
        public int? AWOL { get;set; }
        public int? LEAVE { get;set; }
        public int Model_ID { get;set; }
        public int ID { get;set; }
    }
}
