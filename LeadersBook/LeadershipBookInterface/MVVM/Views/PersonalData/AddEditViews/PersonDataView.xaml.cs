using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.ViewModels;

namespace LeadershipBookInterface.MVVM.Views.PersonalData.AddEditViews;

public partial class PersonDataView : ContentView
{
	public PersonDataView(IModelViewModel<IPerson<int,int, ISoldier<int,int>>> vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}