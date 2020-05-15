using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DRxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class altkategori : ContentPage
	{
		public altkategori()
		{
			InitializeComponent();
		}
		async void uyegirisi(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new uyegirisi());
		}
		async void kategori(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new kategoriler());
		}
		async void kesfet(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new kesfet());
		}
		async void anasayfa(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new MainPage());
		}
		async void arama(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new arama());
		}
		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new filtrele());
		}
		private async void sırala(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new sıralama());
		}
	}
}