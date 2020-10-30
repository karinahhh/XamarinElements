using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DispAlert : ContentPage
	{
		public DispAlert()
		{
			Button alert = new Button
			{
				Text = "Alert",
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.Center
			};
			alert.Clicked += Alert_Clicked;

			Button sheet = new Button
			{
				Text="Display Alert",
				HorizontalOptions=LayoutOptions.Center
			};
			sheet.Clicked += Sheet_Clicked;

			Content = new StackLayout { Children = { alert, sheet } };
		}

		private async void Sheet_Clicked(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("Background Color", "Отменить", "ОК", "Red", "Blue", "Green");
			if (action=="Red")
			{
				BackgroundColor = Color.Red;
				
			}
			else if (action=="Blue")
			{
				BackgroundColor = Color.Blue;
			}
			else if (action=="Green")
			{
				BackgroundColor = Color.Green;
			}
		}

		private void Alert_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Уведомление", "У вас уведомление", "Спасибо:)");
		}
	}
}