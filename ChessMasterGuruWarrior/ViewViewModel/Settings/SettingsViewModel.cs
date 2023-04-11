using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ChessMasterGuruWarrior.ViewViewModel.Settings
{
    public class SettingsViewModel : BaseViewModel
    {
        public string Username { get; set; }
        private string _username = string.Empty;

        public SettingsViewModel()
        {
            
        }

        public string UsernameText
        {
            get { return _username}
            set
            {
                if (_username != value)
                    SetProperty(ref _username, value);
            }
        }
    }
}


