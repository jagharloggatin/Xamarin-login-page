using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace displayalerts
{
    public partial class MainPage : ContentPage
    {
        public MainPage(Alerts.Alerts alerts)
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Alerts.Alerts());
        }
    }
}
