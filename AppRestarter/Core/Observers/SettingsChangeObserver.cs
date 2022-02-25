using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public class SettingsChangeObserver : SingletonBase<ISettingsChangeObserver, SettingsChangeObserver>, ISettingsChangeObserver
    {
        public event ISettingsChangeObserver.SettingsChangedEvent OnSettingsChanged;
        public void NotifySettingsChange(Settings settings) => OnSettingsChanged?.Invoke(settings);
    }
}
