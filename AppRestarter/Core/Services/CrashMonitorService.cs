using System;
using System.Collections.Concurrent;
using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public class CrashMonitorService : SingletonBase<ICrashMonitorService, CrashMonitorService>, ICrashMonitorService
    {
        public event ICrashMonitorService.SignalMonitorTerminationEvent OnSignalMonitorTermination;

        private readonly ILogService _logService;
        private readonly ConcurrentDictionary<Guid, CrashMonitorEntry> _crashMonitorEntries;

        public CrashMonitorService()
        {
            _logService = LogService.GetInstance();
            _crashMonitorEntries = new();
        }

        public void RegisterCrashedApp(WatchedApp app)
        {
            if (_crashMonitorEntries.ContainsKey(app.Id))
            {
                CrashMonitorEntry existingEntry = _crashMonitorEntries[app.Id];
                existingEntry.HitCount++;

                if (existingEntry.HitCount >= existingEntry.App.CrashThreshold)
                {
                    _logService.AddLog(app, "Hit application crash threshold. Killing application and stopping monitoring.");

                    SignalMonitorTermination(app);
                    UnregisterCrashedApp(app);
                }

                return;
            }

            CrashMonitorEntry entry = new()
            {
                App = app,
                HitCount = 0
            };

            if (_crashMonitorEntries.TryAdd(app.Id, entry))
                _logService.AddLog(app, "Detected unexpected shutdown (misconfiguration?). Began monitoring app for crashes...");

        }

        public void UnregisterCrashedApp(WatchedApp app)
        {
            if(_crashMonitorEntries.TryRemove(app.Id, out _))
                _logService.AddLog(app, "Removed application from crash monitor.");
        }

        public void SignalMonitorTermination(WatchedApp app) => OnSignalMonitorTermination?.Invoke(app);
    }
}
