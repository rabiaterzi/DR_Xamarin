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
			await Navigation.PushModalAsync(new MainPage());
		}
	}
}