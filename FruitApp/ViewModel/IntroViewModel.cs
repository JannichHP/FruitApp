using CommunityToolkit.Mvvm.ComponentModel;
using FruitApp.Models;
using FruitApp.Pages;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace FruitApp.ViewModel;

public partial class IntroViewModel : INotifyPropertyChanged
{
    private string _buttonText = "Næste";

    private int _position;

    private int _counter = 1;

    public string ButtonText 
    { 
        get => _buttonText;
        set {
            if (_buttonText != value)
            {
                _buttonText = value;
                OnPropertyChanged(nameof(ButtonText));
            }
        } 
    }

    public int Position 
    { 
        get => _position;
        set
        {
            if (_position != value) 
            {
                _position = value;
                OnPropertyChanged(nameof(Position));
            }
        }
    }

    public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();

    public event PropertyChangedEventHandler PropertyChanged;

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
    async void Next()
    {
        Debug.WriteLine(IntroScreens.Count -1);
        Debug.WriteLine(Position + 1);
        if (Position + 1 >= IntroScreens.Count - 1)
        {
            ButtonText = "Fortsæt";
            _counter++;
        }
        else
        {
            ButtonText = "Næste";
        }
        if (_counter >= 3)
        {
           await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            Position += 1;
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

