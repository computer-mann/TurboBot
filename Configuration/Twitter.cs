using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turbobot.Configuration
{
    public class Twitter
    {
        public Api Api { get; set; }
        public string BearerToken { get; set; }
    }

    public class Api
    {
        public string Key { get; set; }
        public string SecretKey { get; set; }
    }
}
