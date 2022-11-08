using DesignApp.MVVM.Models;
using DesignApp.Services;
using DesignApp.MVVM.Views;

namespace DesignApp;

public partial class App : Application
{
    public static BaseService<Designer> DesignerService { get; private set; }
    public static BaseService<Order> OrderService { get; private set; }

    public App(BaseService<Designer> _designerService, BaseService<Order> _orderService)
    {
        InitializeComponent();
        DesignerService = _designerService;
        OrderService = _orderService;
        MainPage = new NavigationPage(new MainPage());
    }
}

