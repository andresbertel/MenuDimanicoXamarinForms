using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Page1223
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new PrincipalPage();

            this.Detail = new NavigationPage(new DetallePage())
            {
                BarBackgroundColor = Color.Red
            };

            App.FlyoutP = this;           
        }
    }
}
