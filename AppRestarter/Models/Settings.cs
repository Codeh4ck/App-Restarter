using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppRestarter.Models
{
    public class Settings
    {
        public Point WindowPosition { get; set; } = default;
        public bool MinimizeToTray { get; set; } = true;
        public bool StartWithWindows { get; set; } = false;
        public bool AlwaysShowLog { get; set; } = false;
        public bool AutoResizeColumns { get; set; } = true;
        public bool SaveLogsToDisk { get; set; } = true;
        public bool SaveAppLogsSeparately { get; set; } = false;
        public string LogsFolder { get; set; } = Path.Combine(Application.StartupPath, "Logs");
    }
}
