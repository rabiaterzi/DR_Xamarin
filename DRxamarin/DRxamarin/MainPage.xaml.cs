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
			urunlerlistesi.Add(new digerurunler { Id = 7, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001753296001-1.jpg", Point = 3.5, Name = "Kobo Clara HD E-kitap Okuma Cihazı", P_Type = "Elektronik", Brand = "Kobo", Discount = 0, Price = 1228.88 });
			urunlerlistesi.Add(new digerurunler { Id = 8, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001745792001-1.jpg", Point = 3, Name = "Lenco TT-10 Pikap", P_Type = "Elektronik", Brand = "Kodak", Discount = 8, Price = 549 });
			urunlerlistesi.Add(new digerurunler { Id = 9, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001830237001-1.jpg", Point = 2.5, Name = "Xiaomi Yüksek Emişli Akıllı Robot Süpürge", P_Type = "Elektronik", Brand = "Xiaomi", Discount = 16, Price = 3349.00 });
			urunlerlistesi.Add(new digerurunler { Id = 10, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001856330001-1.jpg", Point = 5, Name = "Xiaomi Redmi Powerbank", P_Type = "Elektronik", Brand = "Xiaomi", Discount = 23, Price = 99.90 });
			urunlerlistesi.Add(new digerurunler { Id = 11, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001802919001-1.jpg", Point = 3.5, Name = "Sennheiser Momentum True Wireless Earphone Kulaklık", P_Type = "Elektronik", Brand = "Sennheiser", Discount = 0, Price = 1999.00 });
			urunlerlistesi.Add(new digerurunler { Id = 12, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870491001-1.jpg", Point = 0, Name = "Braun Mgk 3242 Erkek Bakım Kiti ", P_Type = "Elektronik", Brand = "Braun", Discount = 0, Price = 299.00 });
			return urunlerlistesi;
		}

		private List<digerurunler> Getkırtasiye()
		{
			var urunlerlistesi = new List<digerurunler>();
			urunlerlistesi.Add(new digerurunler { Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001865501001-1.jpg", Point = 3, Name = "Kodak A4 Fotokopi Kağıdı", P_Type = "Kırtasiye", Brand = "Kodak", Discount = 10, Price = 15.21 });
			urunlerlistesi.Add(new digerurunler { Id = 2, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000274754-1.jpg", Point = 3, Name = "Scrikss 108 Chrome Tükenmez", P_Type = "Kırtasiye", Brand = "Scrikss", Discount = 30, Price = 10.85 });
			urunlerlistesi.Add(new digerurunler { Id = 3, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000098198-1.jpg", Point = 2.5, Name = "Fbar-Castell Karton Kutu Boya Kalemi", P_Type = "Kırtasiye", Brand = "Faber-Castell", Discount = 30, Price = 34.90 });
			urunlerlistesi.Add(new digerurunler { Id = 4, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000457175-1.jpg", Point = 2.5, Name = "Bic Silinebilir Pastel 24'lü Kutu", P_Type = "Kırtasiye", Brand = "Bic", Discount = 25, Price = 20.18 });
			urunlerlistesi.Add(new digerurunler { Id = 5, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001797607001-1.jpg", Point = 0, Name = "Faber-Castell Jumbo Keçeli Kalem 12'li", P_Type = "Kırtasiye", Brand = "Faber-Castell", Discount = 30, Price = 34.93 });
			urunlerlistesi.Add(new digerurunler { Id = 6, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001793632001-1.jpg", Point = 0, Name = "Crayola Silly Scents Çevirilebilen Pastel Boya Kalemi 12'li", P_Type = "Kırtasiye", Brand = "Crayola", Discount = 33, Price = 39.90 });
			return urunlerlistesi;
		}

		private List<kitaplar> Getcoksatanlar()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Name = "Şeker Portakalı", Author = "Jose Mauro De Vasconcelos", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064031-1.jpg" });
			coksatanlarlist.Add(new kitaplar { Name = "Ben Kirke", Author = "Madeline Miller", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001836978001-1.jpg" });
			coksatanlarlist.Add(new kitaplar { Name = "Hiçbir Karşılaşma...", Author = "Hakan Mengüç", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001858361001-1.jpg" });
			coksatanlarlist.Add(new kitaplar { Id = 1,SubC_Id = 1,Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001869654001-1.jpg", Point = 2,Name = "Akıllandım Artık Şimdi Daha Deliyim",Author = "Nilgün Bodur",CoverType = "İnce Kapak",Publisher = "Destek Yayınları",Discount = 37,Price = 16.38 });
			coksatanlarlist.Add(new kitaplar { Id = 2, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001683949001-1.jpg", Point = 0, Name = "Theta Healing-Derin İnançları Bulun", Author = "Vianna Stibal", CoverType = "İnce Kapak", Publisher = "Kitap", Discount = 25, Price = 17.25 });
			coksatanlarlist.Add(new kitaplar { Id = 3, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870287001-1.jpg", Point = 0, Name = "Kaygı Çağı-Salgın Zamanında", Author = "Kemal Sayar", CoverType = "İnce Kapak", Publisher = "Kapı Yayınları", Discount = 30, Price = 20.30 });
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
		    onecikanlarlist.Add(new kitaplar { Id = 4, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001816072001-1.jpg", Point = 0, Name = "İsimsiz Kız", Author = "Greer Hendricks", CoverType = "Ciltli", Publisher = "Ephesus Yayınları", Discount = 35, Price = 27.30 });
			onecikanlarlist.Add(new kitaplar { Id = 5, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870779001-1.jpg", Point = 0, Name = "Konstantiniyye Oteli", Author = "Zülfü Livaneli", CoverType = "İnce Kapak", Publisher = "İnkılap Kitabevi", Discount = 30, Price = 24.50 });
			onecikanlarlist.Add(new kitaplar { Id = 6, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870778001-1.jpg", Point = 0, Name = "Akira 1.Cilt", Author = "Katsuhiro Otomo", CoverType = "İnce Kapak", Publisher = "Gerekli Şeyler", Discount = 25, Price = 51.00 });
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
