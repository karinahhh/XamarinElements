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
	public partial class lView : ContentPage
	{
		public lView()
		{
            StackLayout stack = new StackLayout();
            var listView1 = new ListView();
            listView1.ItemsSource = new string[]
            {
              "Assad",
              "Sfdsee",
              "Afdfdsfx",
              "Udsfklkdfk",
              "Psdposdöxcvüa"
            };
            stack.Children.Add(listView1);
            Content = stack;
        }
	}
}