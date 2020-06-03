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
	public partial class sıralama : ContentPage
	{
		public List<kitaplar> kitaplar;
		public List<kitaplar> kitaplar2;
		public List<kitaplar> yeni;
		public List<kitaplar> yeni2;
		public sıralama()
		{
			InitializeComponent();
		}
		public sıralama(List<kitaplar> kitap,List<kitaplar> kitap2)
		{
			InitializeComponent();
			kitaplar = new List<kitaplar>();
			kitaplar2 = new List<kitaplar>();
			yeni = new List<kitaplar>();
			yeni2 = new List<kitaplar>();
			kitaplar = kitap;
			kitaplar2 = kitap2;
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
			if(btn.Text=="A-Z")
			{
				yeni= kitaplar.OrderBy(x => x.Name).ToList();
				yeni2=kitaplar2.OrderBy(x => x.Name).ToList();
			}
			else if (btn.Text == "Z-A")
			{
				yeni= kitaplar.OrderByDescending(x => x.Name).ToList();
				yeni2= kitaplar2.OrderByDescending(x => x.Name).ToList();
			}
			else if (btn.Text == "İndirime Göre Azalan")
			{
				yeni= kitaplar.OrderByDescending(x => x.Discount).ToList();
				yeni2= kitaplar2.OrderByDescending(x => x.Discount).ToList();
			}
			else if (btn.Text == "İndirime Göre Artan")
			{
				yeni= kitaplar.OrderBy(x => x.Discount).ToList();
				yeni2= kitaplar2.OrderBy(x => x.Discount).ToList();
			}
			else if (btn.Text == "Fiyata Göre Azalan")
			{
				yeni = kitaplar.OrderByDescending(x => x.Price).ToList();
				yeni2 = kitaplar2.OrderByDescending(x => x.Price).ToList();
			}
			else if (btn.Text == "Fiyata Göre Artan")
			{
				yeni = kitaplar.OrderBy(x => x.Price).ToList();
				yeni2 = kitaplar2.OrderBy(x => x.Price).ToList();
			}
		}
		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new altkategori(yeni,yeni2));
		}
	}
}