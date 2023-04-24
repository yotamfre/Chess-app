using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChessMasterGuruWarrior.ViewViewModel.MainPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        public MainPageView(string username)
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}