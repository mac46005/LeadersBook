using LeadershipBookInterface.MVVM.ViewModels.PersonalData;
using LeadershipBookInterface.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.Factories.ViewModelFactories;
using LeadershipBookInterface.Enums;
using LeadershipBookInterface.MVVM.Views.PersonalData.AddEditViews;

namespace LeadershipBookInterface.MVVM.Factories.ViewFactories
{
    public class AddEditSoldierAbstractViewFactory : IAbstractViewFromModelViewModelFactory
    {
        IModelViewModelFactory<IModelViewModel<IPerson<int, int, ISoldier<int, int>>>> _personDataVMFactory;
        IViewFromModelViewModelFactory<PersonDataView, IPerson<int, int, ISoldier<int, int>>> _personViewFactory;
        public AddEditSoldierAbstractViewFactory
            (
                IModelViewModelFactory<IModelViewModel<IPerson<int, int, ISoldier<int, int>>>> personDataVMFactory,
                IViewFromModelViewModelFactory<PersonDataView, IPerson<int,int,ISoldier<int,int>>> personViewFactory
            )
        {
            _personDataVMFactory = personDataVMFactory;
            _personViewFactory = personViewFactory;
        }
        public object CreateView(params object[] args)
        {
            AddEditSoldierViewOptions option = (AddEditSoldierViewOptions)args[0];
            switch (option)
            {
                case AddEditSoldierViewOptions.personData:
                    if (args.Length < 1)
                        return _personViewFactory.CreateView(_personDataVMFactory.CreateViewModel());
            }
        }
    }
}
}
