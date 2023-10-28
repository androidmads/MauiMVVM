using Microsoft.Extensions.Logging;
using MauiMVVM.ViewModels;
using MauiMVVM.Views;

namespace MauiMVVM;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<ItemEntryPage>();
        builder.Services.AddTransient<ItemEntryPageModel>();

        return builder.Build();
	}
}
