using System;
using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public interface IRestarterService
    {
        int RestartApplication(WatchedApp app);
    }
}
