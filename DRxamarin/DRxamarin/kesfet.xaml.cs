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
	public partial class kesfet : ContentPage
	{
		public kesfet()
		{
			InitializeComponent();
		}

		async void anasayfa(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MainPage());
		}
		async void uyegirisi(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new uyegirisi());
		}
		async void kategori(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new kategoriler());
		}

		private async void arama(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new arama());
		}
	}
}