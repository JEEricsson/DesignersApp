using DesignApp.MVVM.ViewModels;

namespace DesignApp.MVVM.Views;

public partial class DesignerDetailPage : ContentPage
{
    public DesignerDetailPage(DesignerDetailPageViewModel designerDetailPageViewModel)
    {
        InitializeComponent();
        BindingContext = designerDetailPageViewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}
