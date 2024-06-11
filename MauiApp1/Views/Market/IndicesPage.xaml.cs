using MauiApp1.Models.Market;
using MauiApp1.Services;
using MauiApp1.ViewModels.Maket;

namespace MauiApp1.Views.Market;

public partial class IndicesPage : ContentPage
{
	public IndicesPage(MarketsIQService connectService)
	{
		InitializeComponent();

		BindingContext = new IndicesViewModel(connectService);
	}

	private async void OnHandleMoveDetailPage(object sender, SelectionChangedEventArgs e)
	{
        BaseSymbolModel symbolfeed = e.CurrentSelection.FirstOrDefault() as BaseSymbolModel;

		var navigationParameters = new Dictionary<string, object>
		{
			{"SymbolInfo", symbolfeed }
		};

		await Shell.Current.GoToAsync($"MarketDetail", navigationParameters);

    }
}