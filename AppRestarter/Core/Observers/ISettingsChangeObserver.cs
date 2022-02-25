using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface ISettingsChangeObserver
    {
        delegate void SettingsChangedEvent(Settings settings);
        event SettingsChangedEvent OnSettingsChanged;

        void NotifySettingsChange(Settings settings);
    }
}
