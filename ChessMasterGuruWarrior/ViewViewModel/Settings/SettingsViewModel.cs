using ChessMasterGuruWarrior.ViewViewModel.Base;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChessMasterGuruWarrior.ViewViewModel.Settings
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private string _username = "Default Username";
        private string _email = "placeholder@email.com";

        public SettingsViewModel()
        {

        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }



    
}