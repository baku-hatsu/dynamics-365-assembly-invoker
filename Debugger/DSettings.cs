using System;

namespace Debugger
{
    public class DSettings
    {
        public string Title { get; set; }

        public Environment Environment { get; set; }
    }

    public class Environment
    {
        public Uri Instance { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public bool UseUniqueInstance { get; set; }

        public string TokenCachePath { get; set; }
    }
}