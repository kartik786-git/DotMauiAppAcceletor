namespace DotMauiAppAcceletor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMediaElement()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<SampleListDetailViewModel>();
		builder.Services.AddTransient<SampleListDetailPage>();

		builder.Services.AddSingleton<SampleListViewModel>();

		builder.Services.AddSingleton<SampleListPage>();

		builder.Services.AddSingleton<DrawingViewModel>();

		builder.Services.AddSingleton<DrawingPage>();

		builder.Services.AddSingleton<MediaElementViewModel>();

		builder.Services.AddSingleton<MediaElementPage>();

		builder.Services.AddSingleton<WebViewViewModel>();

		builder.Services.AddSingleton<WebViewPage>();

		builder.Services.AddSingleton<SampleViewModel>();

		builder.Services.AddSingleton<SamplePage>();

		builder.Services.AddSingleton<LocalizationViewModel>();

		builder.Services.AddSingleton<LocalizationPage>();

		return builder.Build();
	}
}
