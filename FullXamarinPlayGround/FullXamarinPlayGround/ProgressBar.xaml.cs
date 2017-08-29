using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FullXamarinPlayGround
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgressBar : ContentPage
	{
		public ProgressBar ()
		{
			InitializeComponent ();

		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await progress.ProgressTo(0.8, 900, Easing.Linear);
        }
    }
}