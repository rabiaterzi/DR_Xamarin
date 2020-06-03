using DRxamarin.filtreler;
using DRxamarin.models;
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
		public List<kitaplar> kitaplar;
		public List<kitaplar> kitaplar2;
		public filtrele(List<kitaplar> kitap,List<kitaplar> kitap2)
		{
			InitializeComponent();
			kitaplar = new List<kitaplar>();
			kitaplar2 = new List<kitaplar>();
			kitaplar = kitap;
			kitaplar2 = kitap2;

		}
		public filtrele()
		{
			InitializeComponent();
		}
		private async void arastırmatarih(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new altkategori(kitaplar,kitaplar2));
		}
		private async void arastirma(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new altkategori());
		}
		private async void fkategori(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Kategori());
		}
		private async void fyazar(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Yazar(kitaplar,kitaplar2));
		}
		private async void fyayınevi(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Yayınevi(kitaplar,kitaplar2));
		}

		private async void ffiyat(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Fiyat(kitaplar,kitaplar2));
		}
		private async void fmedya(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MedyaTipi(kitaplar,kitaplar2));
		}
	}
}