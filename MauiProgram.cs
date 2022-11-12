using DesignApp.MVVM.ViewModels;
using DesignApp.MVVM.Models;
using DesignApp.Services;
using DesignApp.MVVM.Views;

namespace DesignApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Black.ttf", "Strong");
                fonts.AddFont("LibreFranklin-Rrgular.ttf", "Regular");
            });

        builder.Services.AddSingleton<BaseService<Designer>>();
        builder.Services.AddSingleton<BaseService<Order>>();

        builder.Services.AddSingleton<BaseViewModel>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddTransient<AddDesignerViewModel>();
        builder.Services.AddTransient<DesignerDetailPageViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<AddDesignerPage>();
        builder.Services.AddTransient<DesignerDetailPage>();

        return builder.Build();
    }
}

