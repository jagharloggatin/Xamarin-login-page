﻿using displayalerts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace displayalerts.Alerts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alerts : ContentPage
    {
        public Alerts()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login3());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login2());

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }


        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new card());
        }
    }
}