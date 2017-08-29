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
	public partial class ToolBarItems : ContentPage
	{
		public ToolBarItems ()
		{
			InitializeComponent ();
		}

        private async void AddNew(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewModelExample());
        }
    }
}