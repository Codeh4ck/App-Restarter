namespace AppRestarter.Models
{
    public class CrashMonitorEntry
    {
        public WatchedApp App { get; set; }
        public int HitCount { get; set; }
    }
}
