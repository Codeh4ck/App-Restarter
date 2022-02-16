using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public interface IRestartObserver
    {
        public delegate void WatchedAppRestarted(WatchedApp app);
        public event WatchedAppRestarted OnWatchedAppRestarted;
        void NotifyRestart(WatchedApp app);
    }
}
