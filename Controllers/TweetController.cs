using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using turbobot.Configuration;

namespace turbobot.Controllers
{
    public class TweetController : Controller
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly ILogger logger;
        private readonly TwitterOptions twitterConf;
        const string url = "https://api.twitter.com/2/tweets/search/stream/rules";

        public TweetController(IHttpClientFactory clientFactory,ILogger<TweetController> logger,
                                    IOptions<TwitterOptions> options)
        {
            this.clientFactory = clientFactory;
            this.logger = logger;
            twitterConf = options.Value;
        }
        public async Task<IActionResult> Index()
        {
            var newUrl = TwitterApiLinks.RecentSearchEndpoint + "mtn turbonet stock &tweet.fields=author_id";
            var client = clientFactory.CreateClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", twitterConf.BearerToken);

            var response =await client.GetStringAsync(newUrl);
           
            ViewData["Title"] = "Tweets";
            return View(model: response);
        }
    }
}
