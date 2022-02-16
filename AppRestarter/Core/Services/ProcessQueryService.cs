using System.Diagnostics;
using System.IO;
using System.Linq;
using AppRestarter.Models;

namespace AppRestarter.Core.Services
{
    public class ProcessQueryService : SingletonBase<IProcessQueryService, ProcessQueryService>, IProcessQueryService
    {
        public bool IsRunning(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                return processes.Length > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool IsRunning(int processId) => Process.GetProcesses().FirstOrDefault(x => x.Id == processId) != null;

        public bool IsRunning(WatchedApp watchedApp)
        {
            return IsRunning(watchedApp.ExecutableName) ||
                   IsRunning(Path.GetFileNameWithoutExtension(watchedApp.ExecutableName));
        }
    }
}
