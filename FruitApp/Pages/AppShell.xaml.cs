using FruitApp.Pages;

namespace FruitApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(IndkoebslistePage), typeof(IndkoebslistePage));
        Routing.RegisterRoute(nameof(TilbudsavisPage), typeof(TilbudsavisPage));
        Routing.RegisterRoute(nameof(ScanPage), typeof(ScanPage));
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
		Routing.RegisterRoute(nameof(IntroPage), typeof(IntroPage));

    }
}
