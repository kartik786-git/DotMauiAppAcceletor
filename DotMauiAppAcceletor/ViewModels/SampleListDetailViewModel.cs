namespace DotMauiAppAcceletor.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class SampleListDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
