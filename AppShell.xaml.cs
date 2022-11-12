using DesignApp.MVVM.Views;

namespace DesignApp;


public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(DesignerDetailPage), typeof(DesignerDetailPage));
        Routing.RegisterRoute(nameof(AddDesignerPage), typeof(AddDesignerPage));
    }
}

