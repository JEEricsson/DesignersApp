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


}
