using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new XamarinElements.MainPage())
			{
				BarBackgroundColor = Color.DarkOrchid
			};
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
