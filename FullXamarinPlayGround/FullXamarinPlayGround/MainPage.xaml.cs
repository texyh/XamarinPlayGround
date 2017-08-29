﻿using FullXamarinPlayGround.MasterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FullXamarinPlayGround
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void search(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchBar());
        }
    }
}
