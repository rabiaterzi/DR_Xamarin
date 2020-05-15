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
	}
}