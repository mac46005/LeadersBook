using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels
{
    public interface IBaseViewModel
    {
        string Title { get; set; }
        string Header { get; set; }
    }
}
