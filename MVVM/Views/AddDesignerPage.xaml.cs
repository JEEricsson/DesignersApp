using CommunityToolkit.Mvvm.Input;
using DesignApp.MVVM.ViewModels;

namespace DesignApp.MVVM.Views;

public partial class AddDesignerPage
{
    public AddDesignerPage()
    {
        InitializeComponent();
        BindingContext = new AddDesignerViewModel();
    }


    async void Cancel_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    async void Save_Clicked(System.Object sender, System.EventArgs e)
    {
        var thisVM = (AddDesignerViewModel)BindingContext;
        var message = thisVM.SaveDesigner();
        await DisplayAlert("Info", message, "OK");
        await Navigation.PopToRootAsync();
    }
}
