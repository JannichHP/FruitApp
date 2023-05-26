using FruitApp.Pages;
using FruitApp.ViewModel;
using Microsoft.Extensions.Logging;

namespace FruitApp;

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

		//Adds The main page (homescreen)
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

		//Adds the List of shopping items
		builder.Services.AddTransient<IndkoebslistePage>();
        builder.Services.AddTransient<ListeViewModel>();

		//Adds the Scan Page
		builder.Services.AddTransient<ScanPage>();
		builder.Services.AddTransient<ScanViewModel>();

        //Adds the Shop Newspaper Page
        builder.Services.AddTransient<TilbudsavisPage>();
        builder.Services.AddTransient<AvisViewModel>();

		//Adds the Details Page
		builder.Services.AddTransient<DetailsPage>();
		builder.Services.AddTransient<DetailsViewModel>();

		//Adds the Intro Page
		builder.Services.AddTransient<IntroPage>();
		builder.Services.AddTransient<IntroViewModel>();

		builder.Services.AddTransient<SettingsPage>();
		builder.Services.AddTransient<SettingViewModel>();

		//Adds the Setting Page






#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
