using DRxamarin.filtreler;
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
	public partial class filtrele : ContentPage
	{
		public filtrele()
		{
			InitializeComponent();
		}

		private async void arastırmatarih(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new altkategori());
		}

		private async void fkategori(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Kategori());
		}
		private async void fyazar(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Yazar());
		}
		private async void fyayınevi(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Yayınevi());
		}

		private async void ffiyat(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Fiyat());
		}
		private async void fmedya(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MedyaTipi());
		}
	}
}