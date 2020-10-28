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
	public partial class wView : ContentPage
	{
        WebView webView;
        public wView()
		{
            
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = "https://github.com/karinahhh" },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            StackLayout stack = new StackLayout();
            stack.Children.Add(webView);
            Content = stack;
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
