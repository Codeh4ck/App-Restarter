using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public interface IProcessQueryService
    {
        bool IsRunning(string processName);
        bool IsRunning(int processId);
        bool IsRunning(WatchedApp watchedApp);
    }
}
