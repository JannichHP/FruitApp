using FruitApp.ViewModel;

namespace FruitApp.Pages;

public partial class IntroPage : ContentPage
{
	public IntroPage(IntroViewModel ivm)
	{
		InitializeComponent();
		BindingContext = ivm;
	}
}