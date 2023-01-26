using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels.PersonalData
{
    public partial class PersonalDataMenuViewModel : ObservableObject
    {
        [RelayCommand]
        public void AddNewSoldier()
        {
            Shell.Current.GoToAsync("personaldata/addeditsoldier");
        }
    }
}
