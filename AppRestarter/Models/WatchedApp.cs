using System;
using System.Collections.Generic;

namespace AppRestarter.Models
{
    public class WatchedApp
    {
        public Guid Id { get; set; }
        public string BaseDirectory { get; set; }
        public string ExecutableName { get; set; }
        public bool PassCmdArgsOnly { get; set; }
        public int CrashThreshold { get; set; }
        public List<CmdArgument> Arguments { get; set; }
        public bool ShowWindow { get; set; }
        public bool RunThroughCmd { get; set; }
        public bool LogApplicationEvents { get; set; }
        public TimeSpan PollInterval { get; set; }
        public int PollIntervalType { get; set; }
        public TimeSpan RestartAfter { get; set; }
        public int RestartAfterType { get; set; }
    }
}
