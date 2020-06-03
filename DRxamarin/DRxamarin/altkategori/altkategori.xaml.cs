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
		public List<kitaplar> yeni;
		public List<kitaplar> yeni2;
		public altkategori()
		{
			InitializeComponent();
			this.BindingContext = this;
			yeni = Arastırmatarih;
			yeni2 = Arastırmatarih2;
		}
		public altkategori(List<kitaplar> kitap, List<kitaplar> kitap2)
		{
			InitializeComponent();
			BindableLayout.SetItemsSource(liste1, kitap);
			BindableLayout.SetItemsSource(liste2, kitap2);
			yeni = new List<kitaplar>();
			yeni2 = new List<kitaplar>();
			yeni = kitap;
			yeni2 = kitap2;
			this.BindingContext = this;
		}
		public List<kitaplar> Arastırmatarih { get => Gettarih(); }
		public List<kitaplar> Arastırmatarih2 { get => Gettarih2(); }
		
		private List<kitaplar> Gettarih()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Id = 12, Name = "Ahitler", Author = "Margaret Atwood", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001867512001-1.jpg", CoverType = "Ciltli", Publisher = "Çizgi Kitabevi", Discount = 50, Price = 15.60 });
			coksatanlarlist.Add(new kitaplar { Id = 1, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001869654001-1.jpg", Point = 2, Name = "Artık Daha Deliyim", Author = "Nilgün Bodur", CoverType = "İnce Kapak", Publisher = "Kaynak Yayınları", Discount = 35, Price = 32.25 });
			coksatanlarlist.Add(new kitaplar { Id = 2, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001683949001-1.jpg", Point = 0, Name = "Derin İnançları Bulun", Author = "Vianna Stibal", CoverType = "İnce Kapak", Publisher = "Çizgi Kitabevi", Discount = 40, Price = 28.50});
			coksatanlarlist.Add(new kitaplar { Id = 9, Name = "Hiçbir Karşılaşma...", Author = "Hakan Mengüç", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001858361001-1.jpg", CoverType = "İnce Kapak", Publisher = "Kaynak Yayınları", Discount = 30, Price = 22.45 });
			coksatanlarlist.Add(new kitaplar { Id = 5, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870779001-1.jpg", Point = 0, Name = "Konstantiniyye Oteli", Author = "Zülfü Livaneli", CoverType = "Cep Boy", Publisher = "İnkılap Kitabevi", Discount = 40, Price = 16.45 });
			coksatanlarlist.Add(new kitaplar { Id = 3, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870287001-1.jpg", Point = 0, Name = "Salgın Zamanında", Author = "Mustafa Küpüşoğlu", CoverType = "İnce Kapak", Publisher = "Alfa Yayıncılık", Discount = 30, Price = 37.60 });
			return coksatanlarlist;
		}

		private List<kitaplar> Gettarih2()
		{
			var coksatanlarlist = new List<kitaplar>();
			coksatanlarlist.Add(new kitaplar { Id = 6, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870778001-1.jpg", Point = 0, Name = "Akira 1.Cilt", Author = "Katsuhiro Otomo", CoverType = "İnce Kapak", Publisher = "Gerekli Şeyler", Discount = 45, Price = 16.38 });
			coksatanlarlist.Add(new kitaplar { Id = 8, Name = "Ben Kirke", Author = "Madeline Miller", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001836978001-1.jpg", CoverType = "Ciltli", Publisher = "İthaki Yayınları", Discount = 27, Price = 35.60 });
			coksatanlarlist.Add(new kitaplar { Id = 11, Name = "Dünyasızlar", Author = "Kaan Murat Yanık", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001860240001-1.jpg", CoverType = "İnce Kapak", Publisher = "Yeditepe Yayınevi", Discount = 28, Price = 29.30 });
			coksatanlarlist.Add(new kitaplar { Id = 4, SubC_Id = 1, Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001816072001-1.jpg", Point = 0, Name = "İsimsiz Kız", Author = "Greer Hendricks", CoverType = "Ciltli", Publisher = "Alfa Yayıncılık", Discount = 37, Price = 27.60 });
			coksatanlarlist.Add(new kitaplar { Id = 10, Name = "Mekanik", Author = "Ian Tregillis", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0001870924001-1.jpg", CoverType = "İnce Kapak", Publisher = "Kırmızı Kedi", Discount = 25, Price =20.50  });
			coksatanlarlist.Add(new kitaplar { Id = 7, Name = "Şeker Portakalı", Author = "Jose Vasconcelos", Photo = "https://i.dr.com.tr/cache/600x600-0/originals/0000000064031-1.jpg", CoverType = "İnce Kapak", Publisher = "Can Çocuk Yayınları", Discount = 25, Price = 51.00 });
			return coksatanlarlist;
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
			await Navigation.PushModalAsync(new filtrele(yeni,yeni2));
		}
		private async void sırala(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new sıralama(Arastırmatarih,Arastırmatarih2));
		}
	}
}