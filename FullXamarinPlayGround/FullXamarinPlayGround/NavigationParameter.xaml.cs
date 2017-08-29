using FullXamarinPlayGround.Models;
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
	public partial class NavigationParameter : ContentPage
	{
		public NavigationParameter (string  title)
		{
			InitializeComponent();
            maincontent.Text = title;
            Title = title;

            Lists.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name ="Emeka",
                    Age = 23
                },
                new Person {Name ="Moses", Age = 28 },
                new Person {Name ="Victor", Age = 25 },
                new Person {Name ="Dayo", Age = 23 },
                new Person {Name="Akpante", Age = 98 }
            };

        }
        
    }
}