using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface IWatcherStatusObserver
    {
        public delegate void WatcherStatusChanged(WatcherStatus status);
        public event WatcherStatusChanged OnWatcherStatusChanged;

        void NotifyWatcherStatus(WatcherStatus status);
    }
}
