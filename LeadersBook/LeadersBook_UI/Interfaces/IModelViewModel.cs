using DbManipulation_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_UI.Interfaces
{
    public interface IModelViewModel<T,U> : IBaseViewModel where T : IModel<U>
    {
        T Model { get; set; }
    }
}
