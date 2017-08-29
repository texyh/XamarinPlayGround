using FullXamarinPlayGround.ViewModels;
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
	public partial class ViewModelExample : ContentPage
	{
		public ViewModelExample ()
		{
			InitializeComponent ();

            BindingContext = new HomeViewMdoel();
		} 
	}
}