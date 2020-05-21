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
	public partial class altkategori : ContentPage
	{
		public altkategori()
		{
			InitializeComponent();
			this.BindingContext = this;
		}
		public List<kitaplar> Arastırmatarih { get => Gettarih(); }
		public List<kitaplar> Arastırmatarih2 { get => Gettarih2(); }

		private List<kitaplar> Gettarih2()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Id = 7, Name = "Şeker Portakalı", Author = "Jose Vasconcelos", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064031-1.jpg", CoverType = "İnce Kapak", Publisher = "Can Çocuk Yayınları", Discount = 30, Price = 16.45 });
			coksatanlarlist.Add(new kitaplar { Id = 8, Name = "Ben Kirke", Author = "Madeline Miller", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001836978001-1.jpg", CoverType = "İnce Kapak", Publisher = "İthaki Yayınları", Discount = 42, Price = 22.04 });
			coksatanlarlist.Add(new kitaplar { Id = 9, Name = "Hiçbir Karşılaşma...", Author = "Hakan Mengüç", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001858361001-1.jpg", CoverType = "İnce Kapak", Publisher = "Destek Yayınları", Discount = 40, Price = 15.60 });
			coksatanlarlist.Add(new kitaplar { Id = 1, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001869654001-1.jpg", Point = 2, Name = "Artık Daha Deliyim", Author = "Nilgün Bodur", CoverType = "İnce Kapak", Publisher = "Destek Yayınları", Discount = 37, Price = 16.38 });
			coksatanlarlist.Add(new kitaplar { Id = 2, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001683949001-1.jpg", Point = 0, Name = "Derin İnançları Bulun", Author = "Vianna Stibal", CoverType = "İnce Kapak", Publisher = "Kronik Kitap", Discount = 25, Price = 17.25 });
			coksatanlarlist.Add(new kitaplar { Id = 3, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870287001-1.jpg", Point = 0, Name = "Salgın Zamanında", Author = "Kemal Sayar", CoverType = "İnce Kapak", Publisher = "Kapı Yayınları", Discount = 30, Price = 20.30 });
			return coksatanlarlist;
		}

		private List<kitaplar> Gettarih()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Id = 10,Name = "Mekanik", Author = "Ian Tregillis", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870924001-1.jpg", CoverType = "İnce Kapak", Publisher = "Kırmızı Kedi", Discount = 25, Price =21.50 });
			coksatanlarlist.Add(new kitaplar { Id = 11,Name = "Dünyasızlar", Author = "Kaan Yanık", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001860240001-1.jpg", CoverType = "İnce Kapak", Publisher = "Turkuvaz Kitap", Discount = 30, Price = 24.50 });
			coksatanlarlist.Add(new kitaplar { Id = 12,Name = "Ahitler", Author = "Margaret Atwood", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001867512001-1.jpg", CoverType = "Ciltli", Publisher = "Doğan Kitap", Discount = 20, Price = 37.60 });
			coksatanlarlist.Add(new kitaplar { Id = 4, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001816072001-1.jpg", Point = 0, Name = "İsimsiz Kız", Author = "Greer Hendricks", CoverType = "Ciltli", Publisher = "Ephesus Yayınları", Discount = 35, Price = 27.30 });
			coksatanlarlist.Add(new kitaplar { Id = 5, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870779001-1.jpg", Point = 0, Name = "Konstantiniyye Oteli", Author = "Zülfü Livaneli", CoverType = "İnce Kapak", Publisher = "İnkılap Kitabevi", Discount = 30, Price = 24.50 });
			coksatanlarlist.Add(new kitaplar { Id = 6, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870778001-1.jpg", Point = 0, Name = "Akira 1.Cilt", Author = "Katsuhiro Otomo", CoverType = "İnce Kapak", Publisher = "Gerekli Şeyler", Discount = 25, Price = 51.00 });
			return coksatanlarlist;
		}
		private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var details = e.Item as kitaplar;
			await Navigation.PushModalAsync(new urunayrıntı(details.Publisher, details.Name, details.Photo, details.Author, details.CoverType, details.Discount, details.Price));
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