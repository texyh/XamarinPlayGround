using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullXamarinPlayGround.Helpers;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FullXamarinPlayGround
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void ConfirmName(object sender, EventArgs e)
        {
            EnteredName.Text = $"Hello {NameEntered.Text}";
        }

        private async void Navigate(object sender, EventArgs e)
        {
            if (NameEntered.Text.IsNullOrEmpty())
            {
                await DisplayAlert("Warning", "You have entered no text, so cant navigate", "Cancel");
                return;
            }

            await Navigation.PushAsync(new NavigationParameter(NameEntered.Text));
        }
    }
}