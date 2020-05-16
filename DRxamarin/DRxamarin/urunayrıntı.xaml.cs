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
		public urunayrıntı()
		{
			InitializeComponent();
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