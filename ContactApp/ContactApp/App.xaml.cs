using ContactApp.Service;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Dane dane = new Dane();
            MainPage = new NavigationPage(new ContactList(dane));
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
