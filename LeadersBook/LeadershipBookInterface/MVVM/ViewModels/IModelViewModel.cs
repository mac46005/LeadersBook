using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels
{
    public interface IModelViewModel<T> : IBaseViewModel
    {
        T Model { get; set; }
    }
}
