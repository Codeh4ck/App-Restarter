using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public interface ILogService
    {
        public delegate void LogEntryAddedEvent(LogEntry logEntry);
        public event LogEntryAddedEvent OnLogEntryAdded;

        public delegate void ClearLogsEvent();
        public event ClearLogsEvent OnClearLogs;

        void AddLog(LogEntry logEntry, LogSettings settings);
        void AddLog(WatchedApp watchedApp, string message, LogSettings settings);
        void AddLog(WatchedApp watchedApp, string message);
        void AddUiLog(WatchedApp watchedApp, string message);
        void ClearLogs();
    }
}
