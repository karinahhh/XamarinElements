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
	public partial class dPicker : ContentPage
	{
		Label lbl;
		DatePicker date;
		public dPicker()
		{
			lbl = new Label { Text = "Выбери дату" };
			date = new DatePicker();
			date.Format = "D";
			//date.MinimumDate = DateTime.Now.AddDays(5);
			//date.MaximumDate = DateTime.Now.AddDays(-5);
			date.DateSelected += Date_DateSelected;
			StackLayout stack = new StackLayout { Children = { lbl, date } };
			this.Content = stack;
		}

		private void Date_DateSelected(object sender, DateChangedEventArgs e)
		{
			lbl.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
		}
	}
}