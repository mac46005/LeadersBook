using CommunityToolkit.Mvvm.ComponentModel;
using LeadersBook_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersBook_UI.MVVM.ViewModels
{
    public abstract class BaseViewModel : ObservableObject, IBaseViewModel
    {
        public string Title { get; set; }
        public string Header { get; set; }
    }
}
