using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface IRestartObserver
    {
        public delegate void WatchedAppRestartedEvent(WatchedApp app);
        public event WatchedAppRestartedEvent OnWatchedAppRestarted;

        void NotifyRestart(WatchedApp app);
    }
}
