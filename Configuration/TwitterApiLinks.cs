using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turbobot.Configuration
{
    public class TwitterApiLinks
    {
        public const string SampleStreamApi = "https://api.twitter.com/2/tweets/stream/sample";
        public const string FilteredStreamEndpoint = "https://api.twitter.com/2/tweets/search/stream";
        public const string RulesEndpoint = "https://api.twitter.com/2/tweets/search/stream/rules";
        public const string RecentSearchEndpoint = "https://api.twitter.com/2/tweets/search/recent?query=";
    }
}
