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
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }


        public string Username
        {
            get => Settings.Username;
            set
            {
                if (Settings.Username == value)
                    return;

                Settings.Username = value;
                OnPropertyChanged();
            }

        }


        public ICommand OnEntryClicked { get; }
        public void OnEntryClickedAsync(object obj)
        {
            
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}