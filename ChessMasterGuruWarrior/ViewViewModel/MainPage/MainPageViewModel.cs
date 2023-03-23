using ChessMasterGuruWarrior.ViewViewModel.Base;
using ChessMasterGuruWarrior.ViewViewModel.Game;
using ChessMasterGuruWarrior.ViewViewModel.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.ViewViewModel.MainPage
{
    class MainPageViewModel : BaseViewModel
    {
        public ICommand OnNewGameClicked { get; set; }

        public ICommand OnSettingsClicked { get; set; }


        public MainPageViewModel()
        {
            OnNewGameClicked = new Command(OnNewGameClickedAsync);
            OnSettingsClicked = new Command(OnSettingsClickedAsync);
        }

        private async void OnNewGameClickedAsync (object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new GameView());
        }

        private async void OnSettingsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
        }
    }
}
