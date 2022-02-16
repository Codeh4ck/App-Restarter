using System;

namespace AppRestarter.Core.Services
{
    public interface IWatcherService : IDisposable
    {
        bool IsWatching();
        bool StartWatching();
        bool StopWatching();
    }
}
