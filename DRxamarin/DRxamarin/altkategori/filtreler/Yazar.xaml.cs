using DRxamarin.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DRxamarin.filtreler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Yazar : ContentPage
	{
		public List<kitaplar> kitaplar;
		public List<kitaplar> kitaplar2;
		public List<kitaplar> yeni;
		public List<kitaplar> yeni2;
		public Yazar()
		{
			InitializeComponent();
		}
		public Yazar(List<kitaplar> kitap, List<kitaplar> kitap2)
		{
			InitializeComponent();
			kitaplar = new List<kitaplar>();
			kitaplar2 = new List<kitaplar>();
			yeni = new List<kitaplar>();
			yeni2 = new List<kitaplar>();
			kitaplar = kitap;
			kitaplar2 = kitap2;
		}
		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new filtrele(yeni,yeni2));
		}
		private void kirmizi(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (btn.TextColor == Color.Red)
			{
				btn.TextColor = Color.Black;
			}
			else
			{
				btn.TextColor = Color.Red;
			}
			yeni = kitaplar.Where(x => x.Author.Equals(btn.Text)).ToList();
			yeni2 = kitaplar2.Where(x => x.Author.Equals(btn.Text)).ToList();
		}
	}
}