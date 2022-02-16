using Microsoft.Win32;
using System.Windows.Forms;

namespace AppRestarter.Utilities
{
    public class Startup
    {
        public static void AddToStartup()
        {
            using RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key == null) return;

            key.SetValue("App Restarter", Application.ExecutablePath);
        }

        public static void RemoveFromStartup()
        {
            using RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key == null) return;

            key.DeleteValue("App Restarter", false);
        }
    }
}
