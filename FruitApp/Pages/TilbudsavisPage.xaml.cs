using FruitApp.ViewModel;

namespace FruitApp.Pages;

public partial class TilbudsavisPage : ContentPage
{
	public TilbudsavisPage(AvisViewModel avm)
	{
		InitializeComponent();
		BindingContext = avm;
	}
}