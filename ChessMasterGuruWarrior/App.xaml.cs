using ChessMasterGuruWarrior.ViewViewModel.MainPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChessMasterGuruWarrior
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPageView();

            MainPage = new NavigationPage(new MainPageView());
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
