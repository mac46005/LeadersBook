using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadershipBookInterface.MVVM.ViewModels
{
    public partial class ModelViewModel<T> : ObservableObject,IModelViewModel<T>
    {
        private T _model;
        public T Model 
        {
            get { return _model; }
            set 
            { 
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }
        private string _title;
        public string Title 
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        private string _header;
        public string Header 
        {
            get { return _header; }
            set
            {
                _header = value;
                OnPropertyChanged(nameof(Header));
            }
        }
    }
}
