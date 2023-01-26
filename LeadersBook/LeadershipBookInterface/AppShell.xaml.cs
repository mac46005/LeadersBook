using LeadershipBookInterface.MVVM.Views.PersonalData;

namespace LeadershipBookInterface
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("personaldata/addeditsoldier", typeof(AddEditSoldierPage));
        }
    }
}