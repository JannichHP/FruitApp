using FruitApp.ViewModel;

namespace FruitApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mv)
	{
		InitializeComponent();
		BindingContext = mv;
	}
}

