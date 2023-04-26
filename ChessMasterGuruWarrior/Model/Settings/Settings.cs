using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

namespace ChessMasterGuruWarrior.Model.Settings
{
    public static class Settings
    {
        private static ISettings AppSettings =>
            CrossSettings.Current;

        public static string Username
        {
            get => AppSettings.GetValueOrDefault(nameof(Username), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Username), value);

        }
        public static string Email
        {
            get => AppSettings.GetValueOrDefault(nameof(Email), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Email), value);
        }

        public static bool EnableAutoQueen
        {
            get => AppSettings.GetValueOrDefault(nameof(EnableAutoQueen), false);
            set => AppSettings.AddOrUpdateValue(nameof(EnableAutoQueen), value);
        }
    }
}
