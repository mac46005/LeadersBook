using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadersBook_ClassLib.Enums;
using LeadersBook_ClassLib.Interfaces;

namespace LeadersBook_ClassLib.Models
{
    public class Soldier<T, U> : ISoldier<T, U>
    {
        public IPerson<T, U, ISoldier<T, U>>? Person { get; set; }
        public ISoldierInfo<T, U, ISoldier<T, U>>? SoldierInfo { get;set; }
        public IPersonalInformation<T, U, ISoldier<T, U>>? PersonalInformation { get;set; }
        public IContactInformation<T, U, ISoldier<T, U>>? ContactInformation { get;set; }
        public IWeaponInformation<T, U, ISoldier<T, U>>? WeaponInformation { get;set; }
        public List<IWeaponsQualification<T, U, ISoldier<T, U>>>? WeaponsQualifications { get;set; }
        public List<IPhysicalTrainingExam<T, U, ISoldier<T, U>>>? PhysicalTrainingExams { get;set; }
        public IMilitaryDriversInformation<T, U, ISoldier<T, U>>? MilitaryDriversInformation { get;set; }
        public IServedCrewWeaponInfo<T, U, ISoldier<T, U>>? ServedCrewWeaponInfo { get;set; }
        public INCO_Information? NCO_Information { get;set; }
        public IVehicleInformation<T, U, ISoldier<T, U>>? VehicleInformation { get;set; }
        public IRemarks<T, U, ISoldier<T, U>>? Remarks { get;set; }
        public T ID { get;set; }
    }
}
