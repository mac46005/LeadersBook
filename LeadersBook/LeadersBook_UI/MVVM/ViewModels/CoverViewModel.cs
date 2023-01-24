using LeadersBook_ClassLib.Interfaces;
using LeadersBook_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_UI.MVVM.ViewModels
{
    public class CoverViewModel : IModelViewModel<ISoldier<int, int>, int>
    {
        public ISoldier<int, int> Model { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public CoverViewModel()
        {
            Title = "Welcome";
            Header = "Leader's Book";
        }
    }
}
