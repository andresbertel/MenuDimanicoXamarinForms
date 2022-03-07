using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page1223
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PopModalAsync();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page2());
        }
    }
}