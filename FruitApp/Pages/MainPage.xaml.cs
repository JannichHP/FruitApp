using FruitApp.ViewModel;

namespace FruitApp.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mv)
	{
		InitializeComponent();
		BindingContext = mv;
	}
}

