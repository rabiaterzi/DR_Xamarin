using DRxamarin.clouddata;
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
	public partial class uyegirisi : TabbedPage
	{
		public uyegirisi()
		{
			InitializeComponent();
		}

		private async void giris(object sender, EventArgs e)
		{   
			//var urun = uye.uyeler.Where(x => x.Eposta.Equals(email2.Text) && x.Sifre.Equals(sifre2.Text));
			if(email2.Text==email.Text && sifre.Text==sifre2.Text)
			{
				await DisplayAlert(" ", "GİRİŞ BAŞARILI", "OK");
				await Navigation.PushModalAsync(new MainPage());
			}
			else
			{
				await DisplayAlert("Hata", "Kullanıcı bulunamadı", "OK");
			}
		}

		private void uyeol(object sender, EventArgs e)
		{
			uyeolusturma uye=new uyeolusturma(isim.Text, soyisim.Text, email.Text, sifre.Text);
			email2.Text = email.Text;
			sifre2.Text = sifre.Text;
			DisplayAlert(" ", "Üyelik başarıyla gerçekleşti", "OK");
		}
	}
}