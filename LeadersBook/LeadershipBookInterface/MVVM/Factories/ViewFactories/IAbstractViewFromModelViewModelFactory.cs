using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.Factories.ViewFactories
{
    public interface IAbstractViewFromModelViewModelFactory
    {
        object CreateView(params object[] args);
    }
}
