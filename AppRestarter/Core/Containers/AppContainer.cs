using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppRestarter.Models;
using Newtonsoft.Json;

namespace AppRestarter.Core.Containers
{
    public class AppContainer : SingletonBase<IAppContainer, AppContainer>, IAppContainer
    {
        private readonly ConcurrentDictionary<Guid, WatchedApp> _applications;

        private static readonly string ApplicationsStorageDirectoryPath =
            Path.Combine(Application.StartupPath, "Settings");

        private static readonly string ApplicationsStorageFilePath =
            Path.Combine(ApplicationsStorageDirectoryPath, "Applications.json");

        public AppContainer()
        {
            _applications = new();
            LoadApplications();
        }

        public bool AddApplication(WatchedApp app)
        {
            if (Contains(app)) return false;
            return _applications.TryAdd(app.Id, app);
        }

        public bool UpdateApplication(WatchedApp app)
        {
            if (AddApplication(app)) return true;

            try
            {
                _applications[app.Id] = app;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<WatchedApp> GetWatchedApps() => _applications.Values.ToList();

        public WatchedApp GetWatchedAppById(Guid id) => _applications.ContainsKey(id) ? _applications[id] : null;

        public bool TryRemoveApplication(WatchedApp app) => _applications.TryRemove(app.Id, out _);

        public bool Contains(WatchedApp app) => _applications.ContainsKey(app.Id);

        public void SaveApplications()
        {
            if (!Directory.Exists(ApplicationsStorageDirectoryPath))
                Directory.CreateDirectory(ApplicationsStorageDirectoryPath);

            List<WatchedApp> applications = _applications.Values.ToList();
            string json = JsonConvert.SerializeObject(applications);

            File.WriteAllText(ApplicationsStorageFilePath, json);
        }

        public void LoadApplications()
        {
            if (!Directory.Exists(ApplicationsStorageDirectoryPath)) return;
            if (!File.Exists(ApplicationsStorageFilePath)) return;

            string json = File.ReadAllText(ApplicationsStorageFilePath);

            List<WatchedApp> watchedApps = JsonConvert.DeserializeObject<List<WatchedApp>>(json);
            if (watchedApps == null) return;

            foreach (WatchedApp watchedApp in watchedApps)
                _applications.TryAdd(watchedApp.Id, watchedApp);
        }
    }
}
