using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.ViewModels;
using LeadershipBookInterface.MVVM.ViewModels.PersonalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewModelFactories
{
    public class IPersonDataViewModelFactory : IModelViewModelFactory<IPerson<int, int, ISoldier<int, int>>>
    {
        public IModelViewModel<IPerson<int, int, ISoldier<int, int>>> CreateViewModel()
        {
            return new PersonDataViewModel();
        }

        public IModelViewModel<IPerson<int, int, ISoldier<int, int>>> CreateViewModel(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
