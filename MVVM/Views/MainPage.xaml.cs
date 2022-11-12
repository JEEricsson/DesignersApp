using CommunityToolkit.Mvvm.ComponentModel;
using DesignApp.MVVM.ViewModels;
namespace DesignApp.MVVM.Views;


public partial class MainPage : ContentPage
{

    public MainPage(MainPageViewModel mainPageViewModel)
    {
        InitializeComponent();

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        BindingContext = new MainPageViewModel();
    }


    async void AddDesigner_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new AddDesignerPage());
    }
}
