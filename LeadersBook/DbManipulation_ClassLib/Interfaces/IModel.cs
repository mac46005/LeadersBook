using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation_ClassLib.Interfaces
{
    public interface IModel<T>
    {
        T ID { get; set; }
    }
}
