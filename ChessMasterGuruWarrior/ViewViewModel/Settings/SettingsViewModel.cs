using ChessMasterGuruWarrior.ViewViewModel.Base;
using ChessMasterGuruWarrior.ViewViewModel.MainPage;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.ViewViewModel.Settings
{
    public class SettingsViewModel : BaseViewModel
    {
        public ICommand OnEntryClicked { get; }

        private string _username = "Default Username";
        private string _email = "placeholder@email.com";

        public SettingsViewModel()
        {
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                    SetProperty(ref _username, value);
            }
        }



        public void OnEntryClickedAsync(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new MainPageView(_username));
        }


        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

    }
}