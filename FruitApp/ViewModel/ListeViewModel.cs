using CommunityToolkit.Mvvm.ComponentModel;
using FruitApp.Pages;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace FruitApp.ViewModel;

public partial class ListeViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> fruits;

    [ObservableProperty]
    string text;

    public ListeViewModel()
    {
        Fruits = new ObservableCollection<string>();
    }

    [ICommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            return;
        }

        Fruits.Add(Text);
        Text = string.Empty;
    }

    [ICommand]
    void Delete(string s)
    {
        if (Fruits.Contains(s))
        {
            Fruits.Remove(s);
        }
    }

    [ICommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync(nameof(DetailsPage));
    }
}

