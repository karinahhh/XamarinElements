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
	public partial class tView : ContentPage
	{
		public tView()
		{
            this.Content = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("Ввод данных")
            {
                new TableSection ("Section1")
                {
                    new EntryCell
                    {
                        Label = "Логин:",
                        Placeholder = "введите логин",
                        Keyboard = Keyboard.Plain
                    },
                    new SwitchCell { Text = "Cell1"},
                    new SwitchCell { Text = "Cell2"}
                },
                new TableSection ("Section2")
                {
                    new EntryCell
                    {
                        Label = "Телефон:",
                        Placeholder = "введите телефон",
                        Keyboard = Keyboard.Telephone
                    },
                    new EntryCell
                    {
                        Label = "Email:",
                        Placeholder = "введите email",
                        Keyboard = Keyboard.Email
                    }
                }
            }
            };
        }
	}
}