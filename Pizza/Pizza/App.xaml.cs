using Pizza.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizza
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Zakazat());
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
