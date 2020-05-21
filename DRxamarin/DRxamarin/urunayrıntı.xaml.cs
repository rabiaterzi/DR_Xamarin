using DRxamarin.filtreler;
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
	public partial class urunayrıntı : ContentPage
	{
		public urunayrıntı(string publisher,string name,string photo,string author,string covertype,int discount,double price)
		{
			InitializeComponent();
            yayınevi.Text = publisher;
            ad.Text = name;
            foto.Source = new UriImageSource()
            {
                Uri = new Uri(photo)
            };
            yazarad.Text = author;
            kapakturu.Text = covertype;
            indirim.Text = discount.ToString();
            fiyat.Text = price.ToString();

		}
        async void sepet(object o, EventArgs args)
        { 
            await DisplayAlert("Ürün","başarıyla sepetinize eklendi","OK");
            await Navigation.PushModalAsync(new sepet(ad.Text,kapakturu.Text,fiyat.Text,foto.Source.ToString()));             
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
        private void ürün(object sender, EventArgs e)
        {
            if (detay1.IsVisible == false)
                detay1.IsVisible = true;
            else
                detay1.IsVisible = false;
        }

        private void ozellık(object sender, EventArgs e)
        {
            if (detay2.IsVisible == false)
                detay2.IsVisible = true;
            else
                detay2.IsVisible = false;
        }

        private void yazar(object sender, EventArgs e)
        {
            if (detay3.IsVisible == false)
                detay3.IsVisible = true;
            else
                detay3.IsVisible = false;
        }

        private void yorum(object sender, EventArgs e)
        {
            if (detay4.IsVisible == false)
                detay4.IsVisible = true;
            else
                detay4.IsVisible = false;
        }
    }
}