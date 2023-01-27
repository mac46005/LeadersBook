using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.ViewModels;
using LeadershipBookInterface.MVVM.ViewModels.PersonalData;
using LeadershipBookInterface.MVVM.Views.PersonalData.AddEditViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewFactories
{
    public class PersonDataViewFactory : IViewFromModelViewModelFactory<PersonDataView, IPerson<int, int, ISoldier<int, int>>>
    {
        public PersonDataView CreateView()
        {
            throw new NotImplementedException();
        }

        public object CreateViewModel(IModelViewModel<IPerson<int, int, ISoldier<int, int>>> modelViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
