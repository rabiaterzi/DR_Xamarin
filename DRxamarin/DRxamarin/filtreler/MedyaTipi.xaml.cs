﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DRxamarin.filtreler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MedyaTipi : ContentPage
	{
		public MedyaTipi()
		{
			InitializeComponent();
		}
		private async void filtre(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new filtrele());
		}
	}
}