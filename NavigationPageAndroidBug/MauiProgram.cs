using Microsoft.Extensions.Logging;
using NavigationPageAndroidBug.View;

namespace NavigationPageAndroidBug;

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
            });

        builder.Services
            .AddTransient(typeof(NavigationPage<>))
            .AddTransient(typeof(ComplexFlowPage1))
            .AddTransient(typeof(ComplexFlowPage2));
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        Routing.RegisterRoute("FlowPage1", typeof(ComplexFlowPage1));
        Routing.RegisterRoute("FlowPage1NavigationPage", typeof(NavigationPage<ComplexFlowPage1>));
        Routing.RegisterRoute("FlowPage2", typeof(ComplexFlowPage2));
        
        return builder.Build();
    }
}