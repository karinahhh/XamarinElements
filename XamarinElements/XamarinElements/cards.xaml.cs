using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class cards : ContentPage
	{
		Button btn;
		public cards()
		{
			btn = new Button()
			{
				Text = "map?"
			};
			btn.Clicked += Btn_Clicked;
			Content = new StackLayout { Children = { btn} };
		}

		private async void Btn_Clicked(object sender, EventArgs e)
		{
			var options = new MapLaunchOptions { Name = "my location" };
			try
			{
				var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
				if (location == null)
				{
					location = await Xamarin.Essentials.Geolocation.GetLocationAsync(new GeolocationRequest
					{
						DesiredAccuracy = GeolocationAccuracy.Medium,
						Timeout = TimeSpan.FromSeconds(30)
					});
				}
				await Xamarin.Essentials.Map.OpenAsync(location, options);
			}
			catch (Exception)
			{

			}
		}
	}
}