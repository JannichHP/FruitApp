using FruitApp.ViewModel;

namespace FruitApp.Pages;

public partial class ScanPage : ContentPage
{
	public ScanPage(ScanViewModel svm)
	{
		InitializeComponent();
		BindingContext = svm;
	}
}