using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_UI.Interfaces
{
    public interface IViewModelFactory<T>
    {
        T Create();
    }
}
