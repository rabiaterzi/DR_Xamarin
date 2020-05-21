using DRxamarin.clouddata;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DRxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class kategoriler : ContentPage
	{
		
		//connection cnn;
		public kategoriler()
		{
			InitializeComponent();
			GetCategories();
			
			//cnn = new connection();
		}

	     protected async void GetCategories()
		{
			connection client = new connection();
			var result = await client.Get<kategoriler>();
			
			if(result != null)
			{ 
				//kategorilerr.ItemsSource = result.ToString();
			}
			//var result = cnn.GetKategorilers().ToList();
			//kategorilerr.ItemsSource = result;
			/*HttpClient client = new HttpClient();
			var response = client.GetStringAsync("http://192.168.1.108:5000/api/kategoriler/");
			var categories = JsonConvert.DeserializeObject<List<kategoriler>>(response.Result);
			kategorilerr.ItemsSource = categories;*/
		}
		async void anasayfa(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new MainPage());
		}
		async void uyegirisi(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new uyegirisi());
		}
		async void kesfet(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new kesfet());
		}
		async void arama(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new arama());
		}
		async void altkategorii(object o, EventArgs args)
		{
			await Navigation.PushModalAsync(new altkategori());
		}
		private void kitap(object sender, EventArgs e)
		{
			A.Text = "   Kitap";
			B.Text = "   Tüm Kitap";
			a1.Text = "Araştırma-Tarih";
			a2.Text = "Bilim";
			a3.Text = "Çizgi Roman";
			a4.Text = "Çocuk ve Gençlik";
			a5.Text = "Ders/Sınav Kitapları";
			a6.Text = "Din Tasavvuf";
			a7.Text = "Edebiyat";
			a8.Text = "Eğitim Başvuru";
			a9.Text = "Felsefe";
			a10.Text = "Foreign Languages";
			a11.Text = "Hobi";
			a12.Text = "Mitoloji Efsane";
			a13.Text = "Mizah";
			a14.Text = "Prestij Kitapları";
			a15.Text = "Sanat-Tasarım";
			a16.Text = "Sesli Kitaplar";
			a5.IsVisible = true;
			a6.IsVisible = true;
			a7.IsVisible = true;
			a8.IsVisible = true;
			a9.IsVisible = true;
			a10.IsVisible = true;
			a11.IsVisible = true;
			a12.IsVisible = true;
			a13.IsVisible = true;
			a14.IsVisible = true;
			a15.IsVisible = true;
			a16.IsVisible = true;
		}
		private void müzik(object sender, EventArgs e)
		{
			A.Text = "   Müzik";
			B.Text = "   Tüm Müzik";
			a1.Text = "Bebek - Çocuk Müzikleri";
			a2.Text = "Karaoke";
			a3.Text = "Müzik Aletleri";
			a4.Text = "Yabancı Albümler";
			a5.Text = "Yerli Albümler";
			a5.IsVisible = true;
			a6.IsVisible = false;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;

		}
		private void film(object sender, EventArgs e)
		{
			A.Text = "   Film";
			B.Text = "   Tüm Film";
			a1.Text = "Belgesel & Spor - Hobi";
			a2.Text = "Çizgi Film & Animasyon";
			a3.Text = "Dizi";
			a4.Text = "Yabancı Sinema";
			a5.Text = "Yerli Sinema";
			a5.IsVisible = true;
			a6.IsVisible = false;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void elektronik(object sender, EventArgs e)
		{
			A.Text = "   Elektronik";
			B.Text = "   Tüm Elektronik";
			a1.Text = "Ev Elektronği";
			a2.Text = "Foto & Kamera";
			a3.Text = "Kobo E-kitap Okuyucular";
			a4.Text = "Robotlar";
			a5.Text = "Tabletler & Çevre Birimleri";
			a6.Text = "Telefon";
			a5.IsVisible = true;
			a6.IsVisible = true;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void oyun(object sender, EventArgs e)
		{
			A.Text = "   Oyun & Konsol";
			B.Text = "   Tüm Oyun & Konsol ";
			a1.Text = "Koleksiyon Ürünleri";
			a2.Text = "Oyun Aksesuarları";
			a3.Text = "Oyun Konsolları";
			a4.Text = "Oyunlar";
			a5.IsVisible = false;
			a6.IsVisible = false;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void hobi(object sender, EventArgs e)
		{
			A.Text = "   Hobi & Oyuncak";
			B.Text = "   Tüm Hobi & Oyuncak";
			a1.Text = "0-3 Yaş Oyuncaklar";
			a2.Text = "Akıllı Oyuncaklar";
			a3.Text = "Bahçe Oyuncakları";
			a4.Text = "Birleştir Oyna Setler";
			a5.Text = "Eğitim Oyuncakları";
			a6.Text = "Figürler";
			a7.Text = "Hobi";
			a8.Text = "Kutu Oyunları";
			a9.Text = "Oyuncaklar";
			a10.Text = "Puzzlelar";
			a11.Text = "Uzaktan Kumandalı Araçlar";
			a5.IsVisible = true;
			a6.IsVisible = true;
			a7.IsVisible = true;
			a8.IsVisible = true;
			a9.IsVisible = true;
			a10.IsVisible = true;
			a11.IsVisible = true;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void kırtasiye(object sender, EventArgs e)
		{
			A.Text = "   Kırtasiye";
			B.Text = "   Tüm Kırtasiye";
			a1.Text = "Boya ve Resim Malzemeleri";
			a2.Text = "Defterler";
			a3.Text = "Diğer Kırtasiye Ürünleri";
			a4.Text = "Kağıt Ürünleri";
			a5.Text = "Kalemler";
			a6.Text = "Kart Zarf ve Mektupluklar";
			a7.Text = "Kitap Ayracı";
			a8.Text = "Kitap Okuma Lambası";
			a9.Text = "Masaüstü Gereçleri";
			a10.Text = "Okul Çantaları";
			a11.Text = "Organizasyon Ürünleri";
			a12.Text = "Sanatsal Malzemeler";
			a13.Text = "Silgi ve Kalemtraşlar";
			a14.Text = "Termos & Mataralar";
			a15.Text = "Yazı Tahtası & Çalışma Masası";
			a16.IsVisible = false;
		}
		private void kisisel(object sender, EventArgs e)
		{
			A.Text = "   Kişisel Ürünler";
			B.Text = "   Tüm Kişisel Ürünler";
			a1.Text = "Hediyelik Ürünler";
			a2.Text = "Kişisel Aksesuarlar";
			a3.Text = "Kişisel Bakım & Sağlık";
			a4.Text = "Parti Malzemeleri";
			a5.IsVisible = false;
			a6.IsVisible = false;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void ekitap(object sender, EventArgs e)
		{
			A.Text = "   E-Kitap";
			B.Text = "   Tüm E-Kitap";
			a1.Text = "Bilgisayarlar";
			a2.Text = "Bilim Kurgu ve Fantastik";
			a3.Text = "Biyografi ve Anı";
			a4.Text = "Çocuk ve Genç";
			a5.Text = "Edebiyat";
			a6.Text = "Edebiyat Dışı";
			a7.Text = "İş Dünyası ve Finans";
			a8.Text = "Karikatürler ve Çizgi Romanlar";
			a9.Text = "Kurgu ve Edebiyat";
			a10.Text = "Müzik";
			a11.Text = "Polisiye ve Şüphe";
			a12.Text = "Romantizm";
			a13.Text = "Soytarı/Mills ve Boon";
			a5.IsVisible = true;
			a6.IsVisible = true;
			a7.IsVisible = true;
			a8.IsVisible = true;
			a9.IsVisible = true;
			a10.IsVisible = true;
			a11.IsVisible = true;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
		private void spor(object sender, EventArgs e)
		{
			A.Text = "   Spor & Outdoor";
			B.Text = "   Tüm Spor & Outdoor";
			a1.Text = "Outdoor Ürünler";
			a2.Text = "Seyahat Ürünleri";
			a3.Text = "Spor Giyim";
			a4.Text = "Spor Giyim Aksesuarları";
			a5.Text = "Spor Malzemeleri";
			a5.IsVisible = true;
			a6.IsVisible = false;
			a7.IsVisible = false;
			a8.IsVisible = false;
			a9.IsVisible = false;
			a10.IsVisible = false;
			a11.IsVisible = false;
			a12.IsVisible = false;
			a13.IsVisible = false;
			a14.IsVisible = false;
			a15.IsVisible = false;
			a16.IsVisible = false;
		}
	}
}