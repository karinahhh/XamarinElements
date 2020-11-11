using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Speech : ContentPage
	{
		float volume, pitch;
		Button btn;
		Slider sli, slid;
		Editor edit;
		public Speech()
		{
			sli = new Slider();
			sli.Maximum = 10.0;
			sli.Minimum = 0.0;
			sli.Value = 1;
			sli.ValueChanged += Sli_ValueChanged;

			slid = new Slider();
			slid.Maximum = 10.0;
			slid.Minimum = 0.0;
			slid.Value = 1;
			slid.ValueChanged += Slid_ValueChanged;

			edit = new Editor
			{
				Placeholder = "Enter text here",
				PlaceholderColor = Color.Blue
			};


			volume = (float)sli.Value;
			pitch = (float)slid.Value;

			btn = new Button()
			{
				Text = "Text to speech"
			};
			btn.Clicked += Btn_Clicked;
			Content = new StackLayout { Children = { edit, sli, slid, btn } };
		}


			private void Slid_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			pitch = (float)slid.Value;
		}

		private void Sli_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			volume = (float)sli.Value;
		}

		


		


		private async void Btn_Clicked(object sender, EventArgs e)
		{
			SpeechOptions settings = new SpeechOptions()
			{
				Volume= volume,
				Pitch=pitch
			};
			if (edit.Text != null)
			{
				await Xamarin.Essentials.TextToSpeech.SpeakAsync(edit.Text, settings);
			}
			
			}

			

		}
		}