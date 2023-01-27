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
        ObservableCollection<ContentView> viewModels = new ObservableCollection<ContentView>();
        public AddEditSoldierViewModel(PersonDataView personDataView)
        {
            PersonDataView _personDataView = personDataView;
            viewModels.Add(_personDataView);
            SelectedView = _personDataView;
        }
        [ObservableProperty]
        ContentView selectedView;
    }
}

