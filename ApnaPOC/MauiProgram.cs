using Microsoft.AspNetCore.Components.WebView.Maui;
using ApnaPOC.Data;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using ApnaPOC.Services;

namespace ApnaPOC;

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
			});
		
		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
        var a = Assembly.GetExecutingAssembly();
        using var stream = a.GetManifestResourceStream("ApnaPOC.appSettings.json");

        var config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();
		string interceptorServiceUrl = null;
        config.Providers.FirstOrDefault().TryGet("interceptorService", out interceptorServiceUrl);		
        builder.Services.AddSingleton<ServiceLocator>(new ServiceLocator(interceptorServiceUrl));
        builder.Services.AddSingleton<UserService>();
        // builder.Configuration.AddConfiguration(config);
        return builder.Build();
	}
}
