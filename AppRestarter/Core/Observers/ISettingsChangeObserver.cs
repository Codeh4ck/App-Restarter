using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface ISettingsChangeObserver
    {
        delegate void SettingsChanged(Settings settings);
        event SettingsChanged OnSettingsChanged;

        void NotifySettingsChange(Settings settings);
    }
}
