using AppRestarter.Models;

namespace AppRestarter.Core.Observers
{
    public class RestartObserver : SingletonBase<IRestartObserver, RestartObserver>, IRestartObserver
    {
        public event IRestartObserver.WatchedAppRestartedEvent OnWatchedAppRestarted;
        public void NotifyRestart(WatchedApp app) => OnWatchedAppRestarted?.Invoke(app);
    }
}
