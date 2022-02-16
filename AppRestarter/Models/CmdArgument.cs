using System;

namespace AppRestarter.Models
{
    public class CmdArgument
    {
        public Guid Id { get; set; }
        public string Argument { get; set; }
        public string Value { get; set; }
    }
}
