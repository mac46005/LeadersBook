using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_ClassLib.Factories
{
    internal interface IModelFactory<T>
    {
        T Create();
        T Create(params object[] args);
    }
}
