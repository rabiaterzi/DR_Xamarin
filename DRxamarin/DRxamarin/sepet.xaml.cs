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
	public partial class sepet : ContentPage
	{
		public sepet(string name,string media,string price,string photo)
		{
			InitializeComponent();
			this.BindingContext = this;
			ad.Text = name;
			medya.Text = media;
			fiyat.Text = price;
			aratoplam.Text = fiyat.Text;
		    
			/*foto.Source = new UriImageSource()
			{
				Uri = new Uri(photo)
			};*/
			//sepettekiler.Add(new Sepet { Name = name, Mediatype = media, Price = price, Photo = photo });
		}
		//public List<Sepet> sepettekiler ; 
		private void Button_Clicked(object sender, EventArgs e)
		{
			if (taksitler.IsVisible == false)
				taksitler.IsVisible = true;
			else
				taksitler.IsVisible = false;
		}

		private void anasayfa(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new MainPage());
		}

		private void silme(object sender, EventArgs e)
		{
			if(check.IsChecked)
			{
				urun.IsVisible = false;
			}
		}
	}
}