using Page1223.Models;
using Page1223.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page1223
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : ContentPage
    {
      public ObservableCollection<MenuItems> menuItems { get; set; }

        public PrincipalPage()
        {
            InitializeComponent();
            menuItems = new ObservableCollection<MenuItems>()
            {
                new MenuItems
                {
                     Tittle ="Top model",
                     ButtonText ="Ir a top model",
                     Text ="Información de top model",
                     Pagina = new TopModel() 
                },
                 new MenuItems
                {
                    Tittle ="Cars",
                     ButtonText ="Ir a top Cars",
                     Text ="Información de top Cars",
                     Pagina = new CarsView()
                },
                  new MenuItems
                {
                    Tittle ="Top Acercar de",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new AboutView()
                },


            };

            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page1());
            App.FlyoutP.IsPresented = false;
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page2());
            App.FlyoutP.IsPresented = false;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page3());
            App.FlyoutP.IsPresented = false;
        }

        private void Button_Clicked_PushPage(object sender, EventArgs e)
        {

        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuItems element = (MenuItems)e.CurrentSelection.FirstOrDefault();
            GoToPage(element.Pagina);

        }

        private async void GoToPage(Page page)
        {
            await App.FlyoutP.Detail.Navigation.PushAsync(page);
            App.FlyoutP.IsPresented = false;
        }
    }
}