using DRxamarin.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace DRxamarin
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		HttpClient client;
		public MainPage()
		{
			InitializeComponent();
			this.BindingContext = this;
			client = new HttpClient();
			
		}
		public List<sliders> Banners { get => GetBanners(); }
		public List<kitaplar> onecikanlar { get => Getonecikanlar(); }
		public List<kitaplar> Coksatanlar { get => Getcoksatanlar(); }
		public List<digerurunler> Kirtasiye { get => Getkırtasiye(); }
		public List<digerurunler> Teknoloji { get => Getteknoloji(); }

		private List<digerurunler> Getteknoloji()
		{
			var urunlerlistesi = new List<digerurunler>();
			urunlerlistesi.Add(new digerurunler { });
			return urunlerlistesi;
		}

		private List<digerurunler> Getkırtasiye()
		{
			var urunlerlistesi = new List<digerurunler>();
			urunlerlistesi.Add(new digerurunler { });
			return urunlerlistesi;
		}

		private List<kitaplar> Getcoksatanlar()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Name = "Şeker Portakalı", Author = "Jose Mauro De Vasconcelos", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064031-1.jpg" });
			coksatanlarlist.Add(new kitaplar { Name = "Ben Kirke", Author = "Madeline Miller", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001836978001-1.jpg" });
			coksatanlarlist.Add(new kitaplar { Name = "Hiçbir Karşılaşma...", Author = "Hakan Mengüç", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001858361001-1.jpg" });
			return coksatanlarlist;
		}

		private List<kitaplar> Getonecikanlar()
		{
			/*List<kitaplar> kitaplist = null;

			var task = client.GetAsync("http://192.168.1.108:5000/api/urunler/kitaplar").ContinueWith((taskResponse) =>
			{
				HttpResponseMessage response = taskResponse.Result;
				var jsonString = response.Content.ReadAsStringAsync();
				jsonString.Wait();
				kitaplist = JsonConvert.DeserializeObject<List<kitaplar>>(jsonString.Result).ToList();
			});
			task.Wait();
			return kitaplist;*/
				var onecikanlarlist = new List<kitaplar>();
				onecikanlarlist.Add(new kitaplar {Name="Mekanik",Author="Ian Tregillis" ,Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870924001-1.jpg" });
				onecikanlarlist.Add(new kitaplar { Name = "Dünyasızlar", Author = "Kaan Murat Yanık", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001860240001-1.jpg" });
				onecikanlarlist.Add(new kitaplar { Name = "Ahitler", Author = "Margaret Atwood", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001867512001-1.jpg" });
				return onecikanlarlist;
		}
		private List<sliders> GetBanners()
		{
			var bannerList = new List<sliders>();
			bannerList.Add( new sliders { Id=1,Photo= "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/0520_d_t_9_851x373_jbl.jpg" });
			bannerList.Add(new sliders {Id=2 ,Photo= "https://i.dr.com.tr/pimages/Content/Uploads/BannerFiles/dr/851x373_fikriyatkuseyri.png" });
			return bannerList;
		}
		//https://cdn0.iconfinder.com/data/icons/slim-square-icons-basics/100/basics-12-128.png
		async void uyegirisi(object o,EventArgs args)
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

		private async void menu(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Menu());
		}
		private async void ayrıntısayfası(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new urunayrıntı());
		}
	}
}
