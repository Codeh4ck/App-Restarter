using System.IO;
using System.Windows.Forms;
using AppRestarter.Core.Services;
using AppRestarter.Models;

namespace AppRestarter.Forms
{
    public partial class FrmLog : Form
    {
        private static FrmLog _instance;
        public static FrmLog GetInstance() => _instance ??= new();

        public FrmLog()
        {
            // We don't need to hold a reference to LogService outside the constructor, this is a singleton after all
            ILogService logService = LogService.GetInstance();

            logService.OnLogEntryAdded += LogService_OnLogEntryAdded;
            logService.OnClearLogs += LogService_OnClearLogs;

            InitializeComponent();
        }

        private void LogService_OnLogEntryAdded(LogEntry logEntry)
        {
            string affectedProgram = Path.GetFileNameWithoutExtension(logEntry.AffectedApplicationName);
            string formattedLog = $"[{logEntry.Date:G}] ({affectedProgram}) {logEntry.Message}\r\n";

            if (InvokeRequired)
                Invoke(() => txtLogs.AppendText(formattedLog));
            else
                txtLogs.AppendText(formattedLog);
        }

        private void LogService_OnClearLogs() => txtLogs.Clear();
    }
}
