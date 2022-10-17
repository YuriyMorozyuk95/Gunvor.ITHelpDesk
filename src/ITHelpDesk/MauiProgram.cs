using System.Reflection;
using Microsoft.Extensions.Configuration;
using Telerik.Maui.Controls.Compatibility;

namespace ITHelpDesk;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseTelerik()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		RegisterConfig(builder);

		builder.Services.AddTransient<MainPage>();

		return builder.Build();
	}

	private static void RegisterConfig(MauiAppBuilder builder)
	{
		var a = Assembly.GetExecutingAssembly();
		using var stream = a.GetManifestResourceStream("ITHelpDesk.appsettings.json");

		var config = new ConfigurationBuilder()
			.AddJsonStream(stream)
			.Build();


		builder.Configuration.AddConfiguration(config);
	}
}
