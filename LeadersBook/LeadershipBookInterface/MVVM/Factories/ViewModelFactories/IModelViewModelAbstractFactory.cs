using LeadershipBookInterface.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewModelFactories
{
    public interface IModelViewModelAbstractFactory<T>
    {
        object CreateModelViewModel(params object[] args);
    }
}
