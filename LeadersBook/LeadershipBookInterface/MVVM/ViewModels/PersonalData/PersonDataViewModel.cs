using CommunityToolkit.Mvvm.ComponentModel;
using LeadersBook_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels.PersonalData
{
    public class PersonDataViewModel : ModelViewModel<IPerson<int,int,ISoldier<int,int>>>
    {

    }
}
