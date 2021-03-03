using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using turbobot.Configuration;

namespace turbobot.Controllers
{
    public class TweetController : Controller
    {
        private readonly IHttpClientFactory clientFactory;
        private readonly ILogger logger;
        private readonly TwitterOptions twitterConf;

        public TweetController(IHttpClientFactory clientFactory,ILogger<TweetController> logger,
                                    IOptions<TwitterOptions> options)
        {
            this.clientFactory = clientFactory;
            this.logger = logger;
            twitterConf = options.Value;
        }
        public async Task<IActionResult> Index()
        {
            var client = clientFactory.CreateClient();
            var response =await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/2");
            //if(!response)
            //{
            //    logger.LogInformation("error message", response.Status);
            //    return Redirect("/");
            //}
            return View(model: response);
        }
    }
}
