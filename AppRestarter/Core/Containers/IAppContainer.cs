using System;
using System.Collections.Generic;
using AppRestarter.Models;

namespace AppRestarter.Core.Containers
{
    public interface IAppContainer
    {
        bool AddApplication(WatchedApp app);
        bool UpdateApplication(WatchedApp app);
        List<WatchedApp> GetWatchedApps();
        WatchedApp GetWatchedAppById(Guid id);
        bool TryRemoveApplication(WatchedApp app);
        bool Contains(WatchedApp app);
        void SaveApplications();
        void LoadApplications();
    }
}
