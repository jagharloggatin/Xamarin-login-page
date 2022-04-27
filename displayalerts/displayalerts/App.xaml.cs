using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace displayalerts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Alerts.Alerts());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
