using System;

namespace AppRestarter.Models
{
    public class LogEntry
    {
        public Guid AffectedApplication { get; set; }
        public string AffectedApplicationName { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
