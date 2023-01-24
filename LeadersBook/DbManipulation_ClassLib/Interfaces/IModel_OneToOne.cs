using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulation_ClassLib.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">This ID data type</typeparam>
    /// <typeparam name="U">Related Model ID data type</typeparam>
    /// <typeparam name="V">Related Model</typeparam>
    public interface IModel_OneToOne<T, U, V> : IModel<T>
    {
        U Model_ID { get; set; }
    }
}
