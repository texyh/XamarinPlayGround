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
    public partial class TabbedPageExample : TabbedPage
    {
        public TabbedPageExample ()
        {
            InitializeComponent();
            Children.Add(new Page1());
            Children.Add(new NavigationParameter("In tapped mode"));
        }
        
    }
}