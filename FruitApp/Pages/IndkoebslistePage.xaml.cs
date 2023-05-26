using FruitApp.ViewModel;

namespace FruitApp.Pages;

public partial class IndkoebslistePage : ContentPage
{
	public IndkoebslistePage(ListeViewModel lvm)
	{
		InitializeComponent();
		BindingContext = lvm;
	}
}