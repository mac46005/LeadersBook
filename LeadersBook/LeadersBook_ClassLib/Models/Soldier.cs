using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Models
{
    public class Soldier : ISoldier<int, int>
    {
        public IPerson<int, int, ISoldier<int, int>>? Person { get; set; }
        public ISoldierInfo<int, int, ISoldier<int, int>>? SoldierInfo { get;set; }
        public IPersonalInformation<int, int, ISoldier<int, int>>? PersonalInformation { get;set; }
        public IContactInformation<int, int, ISoldier<int, int>>? ContactInformation { get;set; }
        public IWeaponInformation<int, int, ISoldier<int, int>>? WeaponInformation { get;set; }
        public List<IWeaponsQualification<int, int, ISoldier<int, int>>>? WeaponsQualifications { get;set; }
        public List<IPhysicalTrainingExam<int, int, ISoldier<int, int>>>? PhysicalTrainingExams { get;set; }
        public IMilitaryDriversInformation<int, int, ISoldier<int, int>>? MilitaryDriversInformation { get;set; }
        public IServedCrewWeaponInfo<int, int, ISoldier<int, int>>? ServedCrewWeaponInfo { get;set; }
        public INCO_Information? NCO_Information { get;set; }
        public IVehicleInformation<int, int, ISoldier<int, int>>? VehicleInformation { get;set; }
        public IRemarks<int, int, ISoldier<int, int>>? Remarks { get;set; }
        public int ID { get;set; }
    }
}
