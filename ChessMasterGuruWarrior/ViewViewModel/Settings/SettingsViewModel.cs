using ChessMasterGuruWarrior.Model.SettingsDB;
using ChessMasterGuruWarrior.ViewViewModel.Base;
using ChessMasterGuruWarrior.ViewViewModel.MainPage;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.ViewViewModel.Settings
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public SettingsViewModel()
        {
            
        }


        public string Username
        {
            get => SettingsDB.Username;
            set
            {
                if (SettingsDB.Username == value)
                    return;

                SettingsDB.Username = value;
                OnPropertyChanged();
            }

        }

        public string Email
        {
            get => SettingsDB.Email;
            set
            {
                if (SettingsDB.Email == value)
                    return;

                SettingsDB.Email = value;
                OnPropertyChanged();
            }

        }

        public bool EnableAutoQueen
        {
            get => SettingsDB.EnableAutoQueen;
            set
            {
                if (SettingsDB.EnableAutoQueen == value)
                    return;

                SettingsDB.EnableAutoQueen = value;
                OnPropertyChanged();
            }

        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}