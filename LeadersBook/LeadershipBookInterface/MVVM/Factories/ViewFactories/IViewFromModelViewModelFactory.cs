using LeadershipBookInterface.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewFactories
{
    public interface IViewFromModelViewModelFactory<T,U> : IViewFactory<T>
    {
        object CreateViewModel(IModelViewModel<U> modelViewModel);
    }
}


