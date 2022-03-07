using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page1223
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutP { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
