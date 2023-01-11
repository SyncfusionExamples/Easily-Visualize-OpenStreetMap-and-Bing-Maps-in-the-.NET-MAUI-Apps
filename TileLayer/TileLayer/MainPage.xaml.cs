using Syncfusion.Maui.Maps;

namespace TileLayer;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        // Add bing maps
        //this.GenerateBingUrl();
	}
    //private async void GenerateBingUrl()
    //{
    //    tileLayer.UrlTemplate = await MapTileLayer.GetBingUrl("https://dev.virtualearth.net/REST/V1/Imagery/Metadata/RoadOnDemand?output=json&uriScheme=https&include=ImageryProviders&key=your_subscription_key");
    //}

}

