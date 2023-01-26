using LeadershipBookInterface.MVVM.ViewModels.PersonalData;

namespace LeadershipBookInterface.MVVM.Views;

public partial class PersonalDataMenuPage : ContentPage
{
	public PersonalDataMenuPage(PersonalDataMenuViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}