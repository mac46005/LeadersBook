﻿using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Interfaces
{
    public interface ISoldier<T,U> : IModel<T>
    {
        IPerson<T,U,ISoldier<T,U>> Person { get; set; }
        ISoldierInfo<T,U,ISoldier<T,U>> SoldierInfo { get; set; }
        IPersonalInformation<T,U,ISoldier<T,U>> PersonalInformation { get; set; }
        IContactInformation<T,U,ISoldier<T,U>> ContactInformation { get; set; }
        IWeaponInformation<T,U,ISoldier<T,U>> WeaponInformation { get; set; }
        List<IWeaponsQualification<T,U, ISoldier<T, U>>> WeaponsQualifications { get; set; }
        List<IPhysicalTrainingExam<T,U,ISoldier<T,U>>> PhysicalTrainingExams { get; set; }
    }
}