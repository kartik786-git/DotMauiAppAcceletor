namespace DotMauiAppAcceletor;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SampleListDetailPage), typeof(SampleListDetailPage));
	}
}
