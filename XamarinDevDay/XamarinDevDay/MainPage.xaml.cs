using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDevDay
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            boton1.Clicked += (s, e) => Continuar();
		}

        // https://tinyurl.com/ybrsycd3
        private async void Continuar()
        {
            if (switch1.IsToggled)
            {
                await Navigation.PushAsync(new MainPage());
                return;
            }
            await DisplayAlert("hola " + texto1.Text, "App movil", "Cerrar");
        }
	}
}
