using MauiMVVM.ViewModels;

namespace MauiMVVM.Views;

public partial class ItemEntryPage : ContentPage
{
    public ItemEntryPage()
	{
		InitializeComponent();
        BindingContext = new ItemEntryPageModel();
    }
}