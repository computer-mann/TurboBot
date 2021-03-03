using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace turbobot.Controllers
{
    public class TweetController : Controller
    {
        private readonly HttpClient httpClient;

        public TweetController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
