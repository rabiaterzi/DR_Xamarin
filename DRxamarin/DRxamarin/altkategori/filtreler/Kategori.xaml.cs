using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DRxamarin.filtreler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kategori : ContentPage
	{
		public Kategori()
		{
			InitializeComponent();
		}

		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new filtrele());
		}
		private void kirmizi(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (btn.TextColor == Color.Red)
			{
				btn.TextColor = Color.Black;
			}
			else
			{
				btn.TextColor = Color.Red;
			}
		}
	}
}