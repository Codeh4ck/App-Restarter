using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AppRestarter.Core.Containers;
using AppRestarter.Core.Observers;
using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public class WatcherService : SingletonBase<IWatcherService, WatcherService>, IWatcherService
    {
        private readonly ConcurrentDictionary<Guid, Thread> _watcherThreads;
        private readonly ConcurrentDictionary<Guid, int> _processIds;

        private readonly ILogService _logService;
        private readonly IAppContainer _appContainer;
        private readonly IRestarterService _restarterService;
        private readonly IProcessQueryService _processQueryService;
        private readonly IWatcherStatusObserver _watcherStatusObserver;

        private WatcherStatus _watcherStatus;

        public WatcherService()
        {
            _watcherThreads = new();
            _processIds = new();

            _logService = LogService.GetInstance();
            _appContainer = AppContainer.GetInstance();
            _restarterService = RestarterService.GetInstance();
            _processQueryService = ProcessQueryService.GetInstance();
            _watcherStatusObserver = WatcherStatusObserver.GetInstance();

            _watcherStatus = WatcherStatus.Idle;
            _watcherStatusObserver.NotifyWatcherStatus(_watcherStatus);
        }

        public bool IsWatched(WatchedApp app)
        {
            return _watcherThreads.ContainsKey(app.Id) && _watcherThreads[app.Id].ThreadState == ThreadState.Background;
        }

        public bool IsWatching()
        {
            return _watcherThreads.Values.Any(x => x.ThreadState == ThreadState.Background);
        }

        public bool StartWatching()
        {
            if (_watcherStatus == WatcherStatus.Running) return false;

            int watchCount = 0;
            foreach (WatchedApp app in _appContainer.GetWatchedApps())
            {
                if (!_watcherThreads.ContainsKey(app.Id))
                {
                    Thread watcherThread = new(() => WatchLoop(app));

                    watcherThread.SetApartmentState(ApartmentState.MTA);
                    watcherThread.IsBackground = true;
                    watcherThread.Name = $"{app.Id}";
                    
                    _watcherThreads.TryAdd(app.Id, watcherThread);

                    watcherThread.Start();
                    _logService.AddLog(app, "Started monitoring application.");

                    watchCount++;
                }
            }

            if (watchCount > 0)
            {
                _watcherStatus = WatcherStatus.Running;
                _watcherStatusObserver.NotifyWatcherStatus(_watcherStatus);
            }

            return watchCount > 0;
        }

        private void WatchLoop(WatchedApp app)
        {
            while (IsWatched(app))
            {
                bool isProcessRunning = _processIds.ContainsKey(app.Id) ?
                    _processQueryService.IsRunning(_processIds[app.Id]) :
                    _processQueryService.IsRunning(app);
                
                if (!isProcessRunning)
                {
                    _logService.AddLog(app, "Detected application shut down.");

                    if (_processIds.ContainsKey(app.Id))
                        Thread.Sleep(app.RestartAfter);
                    
                    int processId = _restarterService.RestartApplication(app);

                    if (!_processIds.TryAdd(app.Id, processId))
                        _processIds[app.Id] = processId;
                }

                Thread.Sleep(app.PollInterval);
            }
        }

        public bool StopWatching()
        {
            if (_watcherStatus != WatcherStatus.Running) return false;

            int stopCount = 0;

            foreach (KeyValuePair<Guid, Thread> threadPair in _watcherThreads)
            {
                threadPair.Value.Abort();

                if (_watcherThreads.TryRemove(threadPair.Key, out _))
                {
                    stopCount++;

                    WatchedApp app = _appContainer.GetWatchedAppById(threadPair.Key);
                    _logService.AddLog(app, "Stopped monitoring application.");
                }
            }

            _watcherThreads.Clear();
            _processIds.Clear();

            if (stopCount > 0)
            {
                _watcherStatus = WatcherStatus.Stopped;
                _watcherStatusObserver.NotifyWatcherStatus(_watcherStatus);
            }

            return stopCount > 0;
        }

        public void Dispose() => StopWatching();
    }
}
