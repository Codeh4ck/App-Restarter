using System;

namespace AppRestarter.Utilities.Extensions
{
    public static class TimeSpanExtensions
    {
        public static string ToHumanReadableString(this TimeSpan t)
        {
            if (t.TotalSeconds <= 1)
                return $@"{t.Milliseconds} milliseconds";
            
            if (t.TotalMinutes <= 1)
                return $@"{t:%s} seconds";
            
            if (t.TotalHours <= 1)
                return $@"{t:%m} minutes";
            
            if (t.TotalDays <= 1)
                return $@"{t:%h} hours";

            return $@"{t:%d} days";
        }
    }
}
