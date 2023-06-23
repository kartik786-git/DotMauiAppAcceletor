namespace DotMauiAppAcceletor.Views;

public partial class SampleListDetailPage : ContentPage
{
	public SampleListDetailPage(SampleListDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
