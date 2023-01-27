using LeadershipBookInterface.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewModelFactories
{
    public interface IModelViewModelFactory<T>
    {
        IModelViewModel<T> CreateViewModel();
        IModelViewModel<T> CreateViewModel(params object[] args);
    }
}
