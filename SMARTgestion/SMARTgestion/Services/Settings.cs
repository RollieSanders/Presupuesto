using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SMARTgestion.Services.Helpers
{
    public static class UserSettings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }
        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }
        public static string Password
        {
            get => AppSettings.GetValueOrDefault(nameof(Password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Password), value);
        }
        public static string Empleado
        {
            get => AppSettings.GetValueOrDefault(nameof(Empleado), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Empleado), value);
        }
        public static string CentroCosto_Gestor
        {
            get => AppSettings.GetValueOrDefault(nameof(CentroCosto_Gestor), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(CentroCosto_Gestor), value);
        }
        public static void ClearAllData()
        {
            AppSettings.Clear();
        }
    }
}

