using System;

namespace AppRestarter.Models
{
    public class Update
    {
        public Version Version { get; set; }
        public string ChangeLog { get; set; }
        public string DownloadUrl { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
