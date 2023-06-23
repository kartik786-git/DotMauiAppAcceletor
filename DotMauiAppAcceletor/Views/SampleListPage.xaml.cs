namespace DotMauiAppAcceletor.Views;

public partial class SampleListPage : ContentPage
{
	SampleListViewModel ViewModel;

	public SampleListPage(SampleListViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
