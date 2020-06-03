using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DRxamarin.models;

namespace DRxamarin.filtreler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Fiyat : ContentPage
	{
		public List<kitaplar> kitaplar;
		public List<kitaplar> kitaplar2;
		public List<kitaplar> yeni;
		public List<kitaplar> yeni2;
		public Fiyat()
		{
			InitializeComponent();
		}
		public Fiyat(List<kitaplar> kitap, List<kitaplar> kitap2)
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
			if(btn.TextColor==Color.Red)
			{
				btn.TextColor = Color.Black;
			}
			else
			{
                btn.TextColor = Color.Red;
			}
			if (btn.Text == "0 TL - 25 TL (10943)")
			{
				yeni = kitaplar.Where(x => x.Price >= 0 && x.Price < 25).ToList();
				yeni2 = kitaplar2.Where(x => x.Price >= 0 && x.Price < 25).ToList();
			}
			else if (btn.Text == "25 TL - 50 TL (4919)")
			{
				yeni = kitaplar.Where(x => x.Price >= 25 && x.Price < 50).ToList();
				yeni2 = kitaplar2.Where(x => x.Price >= 25 && x.Price < 50).ToList();
			}
			else if (btn.Text == "50 TL - 100 TL (597)")
			{
				yeni = kitaplar.Where(x => x.Price >= 50 && x.Price < 100).ToList();
				yeni2 = kitaplar2.Where(x => x.Price >= 50 && x.Price < 100).ToList();
			}
			else if (btn.Text == "100 TL - 250 TL (102)")
			{
				yeni = kitaplar.Where(x => x.Price >= 100 && x.Price < 250).ToList();
				yeni2 = kitaplar2.Where(x => x.Price >= 100 && x.Price < 250).ToList();
			}
			else if (btn.Text == "250 TL ve Üzeri (30)")
			{
				yeni = kitaplar.Where(x => x.Price >= 250).ToList();
				yeni2 = kitaplar2.Where(x => x.Price >= 250).ToList();
			}
		}
	}
}