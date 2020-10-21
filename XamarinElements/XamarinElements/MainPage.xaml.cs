using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinElements
{
	public partial class MainPage : ContentPage
	{
		Button btn, btn2, btn3, btn4, btn5, btn6;
		public MainPage()
		{
			btn = new Button { Text = "Entry/editor" };
			btn.Clicked += Btn_Clicked;

			btn2 = new Button { Text = "ListView" };
			btn2.Clicked += Btn2_Clicked;

			btn3 = new Button { Text = "DataPicker" };
			btn3.Clicked += Btn3_Clicked;

			btn4 = new Button { Text = "TableView" };
			btn4.Clicked += Btn4_Clicked;

			btn5 = new Button { Text = "WebView" };
			btn5.Clicked += Btn5_Clicked;

			btn6 = new Button { Text = "Timer" };
			btn6.Clicked += Btn6_Clicked;

			StackLayout st = new StackLayout();
			st.Children.Add(btn);
			st.Children.Add(btn2);
			st.Children.Add(btn3);
			st.Children.Add(btn4);
			st.Children.Add(btn5);
			st.Children.Add(btn6);
			Content = st;


		}

		private async void Btn6_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Timer());
		}

		private async void Btn5_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new wView());
		}

		private async void Btn4_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new tView());
		}

		private async void Btn3_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new dPicker());
		}

		private async void Btn2_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new lView());
		}

		private async void Btn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Enditor());
		}
	}
}
