using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace MauiMVVM.ViewModels;

public partial class ItemEntryPageModel : ObservableObject
{
    [ObservableProperty]
    private int _id;
    [ObservableProperty]
	private string _name;
	[ObservableProperty]
	private string _description;

    [ICommand]
	public async void Save()
	{
        await Application.Current.MainPage.DisplayAlert("MAUI MVVM Sample", "Item Saved Successfully", "OK");
    }
}