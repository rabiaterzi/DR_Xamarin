using DRxamarin.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
		public MainPage()
		{
			InitializeComponent();
			this.BindingContext = this;
			
		}
		public List<sliders> Banners { get => GetBanners(); }

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
	}
}
