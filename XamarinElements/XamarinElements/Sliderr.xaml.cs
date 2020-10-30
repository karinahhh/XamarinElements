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
	public partial class Sliderr : ContentPage
	{
		Label header;
		public Sliderr()
		{
			header = new Label
			{
				Text = "This is a slider",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			Slider slid = new Slider { Minimum = 0, Maximum = 50, Value = 30 };
			slid.ValueChanged += Slid_ValueChanged;

			Content = new StackLayout { Children = { header, slid } };
		}

		private void Slid_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			header.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
		}
	}
}