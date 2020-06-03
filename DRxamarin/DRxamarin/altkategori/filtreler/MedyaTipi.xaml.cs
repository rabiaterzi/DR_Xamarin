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
	public partial class MedyaTipi : ContentPage
	{
		public List<kitaplar> kitaplar;
		public List<kitaplar> kitaplar2;
		public List<kitaplar> yeni;
		public List<kitaplar> yeni2;
		public MedyaTipi()
		{
			InitializeComponent();
		}
		public MedyaTipi(List<kitaplar> kitap, List<kitaplar> kitap2)
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
			if(btn.Text== "İnce Kapak (16133)")
			{
				yeni = kitaplar.Where(x => x.CoverType.Equals("İnce Kapak")).ToList();
				yeni2= kitaplar2.Where(x => x.CoverType.Equals("İnce Kapak")).ToList();
			}
			else if (btn.Text == "Ciltli (406)")
			{
				yeni = kitaplar.Where(x => x.CoverType.Equals("Ciltli")).ToList();
				yeni2 = kitaplar2.Where(x => x.CoverType.Equals("Ciltli")).ToList();
			}
			else if (btn.Text == "Cep Boy (36)")
			{
				yeni = kitaplar.Where(x => x.CoverType.Equals("Cep Boy")).ToList();
				yeni2 = kitaplar2.Where(x => x.CoverType.Equals("Cep Boy")).ToList();
			}
		}
	}
}