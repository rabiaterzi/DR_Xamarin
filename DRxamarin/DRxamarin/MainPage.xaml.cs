using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		}
		//https://cdn0.iconfinder.com/data/icons/slim-square-icons-basics/100/basics-12-128.png
		async void uyegirisi(object o,EventArgs args)
		{
			await Navigation.PushModalAsync(new uyegirisi());
		}
	}
}
