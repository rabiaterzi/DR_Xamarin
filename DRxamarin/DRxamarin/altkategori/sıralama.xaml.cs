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
	public partial class sıralama : ContentPage
	{
		public sıralama()
		{
			InitializeComponent();
		}
		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new altkategori());
		}
	}
}