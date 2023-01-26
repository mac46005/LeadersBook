using CommunityToolkit.Mvvm.ComponentModel;
using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.Views.PersonalData.AddEditViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels.PersonalData
{
    public partial class AddEditSoldierViewModel : ModelViewModel<ISoldier<int,int>>
    {
        [ObservableProperty]
        ObservableCollection<object> viewModels;
        public AddEditSoldierViewModel()
        {
            PersonDataView personDataView = new PersonDataView();
            viewModels.Add(personDataView);
            SelectedView = personDataView;
        }
        [ObservableProperty]
        object selectedView;
    }
}

