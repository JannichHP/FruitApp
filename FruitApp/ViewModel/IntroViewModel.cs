using CommunityToolkit.Mvvm.ComponentModel;
using FruitApp.Models;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace FruitApp.ViewModel;

public partial class IntroViewModel : ObservableObject
{
    public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();

    [ObservableProperty]
    private string _buttonText = "Next";

    [ObservableProperty]
    private int _position;

    public IntroViewModel()
    {
        IntroScreens.Add(new IntroScreenModel
        {
            IntroTitle = "Scan",
            IntroImage = "scan",
            IntroDescription = "Scan vores varere for at se priser og detaljer",
        });

        IntroScreens.Add(new IntroScreenModel
        {
            IntroTitle = "Indkøbsliste",
            IntroImage = "list",
            IntroDescription = "Opret en smart indkøbsliste, som kan vise totale pris, printes og meget mere.",
        });

        IntroScreens.Add(new IntroScreenModel
        {
            IntroTitle = "Tilbudsavis",
            IntroImage = "news",
            IntroDescription = "Tjek alle vores tilbud ud i tilbudsavisen",
        });

        IntroScreens.Add(new IntroScreenModel
        {
            IntroTitle = "Bestil og afhent",
            IntroImage = "cart",
            IntroDescription = "Bestil i appen og afhent",
        });
    }

    [ICommand]
    void Next()
    {
        if (Position >= IntroScreens.Count - 1)
        {

        }
        else
        {
            Position += 1;
        }
    }
}

