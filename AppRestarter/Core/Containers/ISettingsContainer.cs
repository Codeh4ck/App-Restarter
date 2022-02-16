using AppRestarter.Models;

namespace AppRestarter.Core.Containers
{
    public interface ISettingsContainer
    {
        Settings GetSettings();
        void LoadSettings();
        void SaveSettings();
        void ModifySettings(Settings settings);
    }
}
