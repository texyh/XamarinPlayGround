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
	public partial class DisplayAction : ContentPage
	{
		public DisplayAction ()
		{
			InitializeComponent ();
		}

        private async void ShowColors(object sender, EventArgs e)
        {
            var colors = new string[] { "red", "black", "yellow", "green" };
            var color = await DisplayActionSheet("Colors", "cancel", "Destruction", colors);

            if (color == "red")
            {
                BackgroundColor = Color.Red;
            }
            else if(color == "Black")
            {
                BackgroundColor = Color.Black;
            }

            else if (color == "yellow")
            {
                BackgroundColor = Color.Yellow;
            }

            else if (color == "green")
            {
                BackgroundColor = Color.Green;
            }
        }
    }
}