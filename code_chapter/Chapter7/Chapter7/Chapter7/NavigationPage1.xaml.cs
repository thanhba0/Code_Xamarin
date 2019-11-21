﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
        }
        protected async void Navigate(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NavigationPage2());
        }
    }

}