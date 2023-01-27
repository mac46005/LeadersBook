using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.ViewModels;

namespace LeadershipBookInterface.MVVM.Views.PersonalData;

public partial class AddEditSoldierPage : ContentPage
{
	public AddEditSoldierPage(IModelViewModel<ISoldier<int,int>> vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}