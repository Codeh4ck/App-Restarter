using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public class WatcherStatusObserver : SingletonBase<IWatcherStatusObserver, WatcherStatusObserver>, IWatcherStatusObserver
    {
        public event IWatcherStatusObserver.WatcherStatusChangedEvent OnWatcherStatusChanged;
        public void NotifyWatcherStatus(WatcherStatus status) => OnWatcherStatusChanged?.Invoke(status);
    }
}
