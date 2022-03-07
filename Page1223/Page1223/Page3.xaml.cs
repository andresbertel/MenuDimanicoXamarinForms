using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page1223
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : CarouselPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        public void Register<T>(string description, params object[] args)
        where T : ICommand
        {
            var command = (ICommand)Activator.CreateInstance(typeof(T), args);
          //  _tasks.Add(new Task { Description = description, Command = command });
        }
    }
}