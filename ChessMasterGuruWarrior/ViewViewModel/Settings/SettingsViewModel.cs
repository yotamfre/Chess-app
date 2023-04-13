using ChessMasterGuruWarrior.ViewViewModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChessMasterGuruWarrior.ViewViewModel.Settings
{
    public class SettingsViewModel : BaseViewModel
    {
        private string _username = "Default Username";

        public SettingsViewModel()
        {
            
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
    }
}


