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
	public partial class SearchBar : ContentPage
	{
        private readonly List<string> _names = new List<string>
        {
            "emeka", "Moses", "Esther", "victor"
        };

		public SearchBar ()
		{
			InitializeComponent ();
            list.ItemsSource = _names;
		}

        private void search_SearchButtonPressed(object sender, EventArgs e)
        {
            var word = search.Text;

            var result = _names.Where(x => x.Contains(word)).ToList();
            list.ItemsSource = result;
        }
    }
}