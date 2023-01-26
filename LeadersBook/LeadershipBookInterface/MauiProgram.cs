using LeadersBook_ClassLib.Interfaces;
using LeadershipBookInterface.MVVM.ViewModels;
using LeadershipBookInterface.MVVM.ViewModels.PersonalData;
using LeadershipBookInterface.MVVM.Views;
using LeadershipBookInterface.MVVM.Views.PersonalData;
using LeadershipBookInterface.MVVM.Views.PersonalData.AddEditViews;

namespace LeadershipBookInterface
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<PersonalDataMenuPage>();
            builder.Services.AddTransient<PersonalDataMenuViewModel>();
            builder.Services.AddTransient<IModelViewModel<ISoldier<int, int>>, AddEditSoldierViewModel>();
            builder.Services.AddTransient<IModelViewModel<IPerson<int, int, ISoldier<int, int>>>, PersonDataViewModel>();
            builder.Services.AddTransient<AddEditSoldierPage>();
            builder.Services.AddTransient<PersonDataView>();

            return builder.Build();
        }
    }
}