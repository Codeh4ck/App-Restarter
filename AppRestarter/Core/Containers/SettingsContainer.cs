using System.IO;
using System.Windows.Forms;
using AppRestarter.Core.Observers;
using AppRestarter.Models;
using Newtonsoft.Json;

namespace AppRestarter.Core.Containers
{
    public class SettingsContainer : SingletonBase<ISettingsContainer, SettingsContainer>, ISettingsContainer
    {
        private static readonly string ApplicationsSettingsDirectoryPath =
            Path.Combine(Application.StartupPath, "Settings");

        private static readonly string ApplicationsSettingsFilePath =
            Path.Combine(ApplicationsSettingsDirectoryPath, "Settings.json");

        private Settings _settings;

        private readonly ISettingsChangeObserver _settingsChangeObserver;

        public SettingsContainer()
        {
            LoadSettings();
            _settingsChangeObserver = SettingsChangeObserver.GetInstance();
        }

        public Settings GetSettings()
        {
            return _settings;
        }

        public void LoadSettings()
        {
            if (!Directory.Exists(ApplicationsSettingsDirectoryPath) && !File.Exists(ApplicationsSettingsFilePath))
            {
                _settings = new();
                return;
            }

            string json = File.ReadAllText(ApplicationsSettingsFilePath);
            _settings = JsonConvert.DeserializeObject<Settings>(json);
        }

        public void SaveSettings()
        {
            if (!Directory.Exists(ApplicationsSettingsDirectoryPath))
                Directory.CreateDirectory(ApplicationsSettingsDirectoryPath);

            string json = JsonConvert.SerializeObject(_settings);
            File.WriteAllText(ApplicationsSettingsFilePath, json);
        }

        public void ModifySettings(Settings settings)
        {
            _settings = settings;
            _settingsChangeObserver.NotifySettingsChange(settings);
        }
    }
}
