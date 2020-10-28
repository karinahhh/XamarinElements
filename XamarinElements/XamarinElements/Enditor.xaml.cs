﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Enditor : ContentPage
	{
		Label lbl;
		Button btn;
		Editor edit;
		public Enditor()
		{
			edit = new Editor { Placeholder = "Enter text here", PlaceholderColor = Color.Blue, CharacterSpacing = 5 };

			StackLayout st = new StackLayout();

			st.Children.Add(edit);
			Content = st;

			/*
			lbl = new Label { Text = "Entry" };

			btn = new Button();
			btn.Text = "ListView";
			btn.Clicked += Btn_Clicked;

			StackLayout st = new StackLayout();
			st.Children.Add(lbl);
			st.Children.Add(btn);
			Content = st;

		}

		private async void Btn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new lView());
		}*/
		}
	}
}