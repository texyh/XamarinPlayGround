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
	public partial class SliderExample : ContentPage
	{
		public SliderExample ()
		{
			InitializeComponent ();
		}

        private void setlabel(object sender, ValueChangedEventArgs e)
        {
            lable.Text = slider.Value.ToString();
        }
    }
}