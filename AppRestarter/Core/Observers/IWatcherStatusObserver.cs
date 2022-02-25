using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface IWatcherStatusObserver
    {
        public delegate void WatcherStatusChangedEvent(WatcherStatus status);
        public event WatcherStatusChangedEvent OnWatcherStatusChanged;

        void NotifyWatcherStatus(WatcherStatus status);
    }
}
