using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public interface ICrashMonitorService
    {
        delegate void SignalMonitorTerminationEvent(WatchedApp app);
        event SignalMonitorTerminationEvent OnSignalMonitorTermination;

        void RegisterCrashedApp(WatchedApp app);
        void UnregisterCrashedApp(WatchedApp app);
        void SignalMonitorTermination(WatchedApp app);
    }
}
