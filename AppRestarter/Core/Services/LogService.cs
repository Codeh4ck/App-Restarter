using System;
using System.IO;
using AppRestarter.Core.Containers;
using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public class LogService : SingletonBase<ILogService, LogService>, ILogService
    {
        private readonly ISettingsContainer _settingsContainer;

        public LogService() => _settingsContainer = SettingsContainer.GetInstance();

        public event ILogService.LogEntryAddedEvent OnLogEntryAdded;
        public event ILogService.ClearLogsEvent OnClearLogs;

        public void AddLog(LogEntry logEntry, LogSettings settings)
        {
            string affectedProgram = Path.GetFileNameWithoutExtension(logEntry.AffectedApplicationName);
            string formattedLog = $"[{logEntry.Date:G}] ({affectedProgram}) {logEntry.Message}";
            
            if (settings.SaveToDisk)
            {
                string logsFolder = _settingsContainer.GetSettings().LogsFolder;
                if (Directory.Exists(logsFolder))
                {
                    string fullPath = Path.Combine(logsFolder, $"App Restarter - Logs.txt");

                    if (settings.SaveSeparately)
                        fullPath = Path.Combine(logsFolder, $"{affectedProgram}.txt");

                    File.AppendAllText(fullPath, formattedLog + "\r\n");
                }
            }

            OnLogEntryAdded?.Invoke(logEntry);
        }

        public void AddLog(WatchedApp watchedApp, string message, LogSettings settings)
        {
            if (!watchedApp.LogApplicationEvents) return;

            LogEntry logEntry = new()
            {
                Message = message,
                AffectedApplication = watchedApp.Id,
                AffectedApplicationName = watchedApp.ExecutableName,
                Date = DateTime.Now
            };

            AddLog(logEntry, settings);
        }

        public void AddLog(WatchedApp watchedApp, string message)
        {
            Settings settings = _settingsContainer.GetSettings();

            AddLog(watchedApp, message, new()
            {
                SaveSeparately = settings.SaveAppLogsSeparately,
                SaveToDisk = settings.SaveLogsToDisk
            });
        }

        public void AddUiLog(WatchedApp watchedApp, string message)
        {
            AddLog(watchedApp, message, new() { SaveSeparately = false, SaveToDisk = false });
        }

        public void ClearLogs()
        {
            OnClearLogs?.Invoke();
        }
    }
}
