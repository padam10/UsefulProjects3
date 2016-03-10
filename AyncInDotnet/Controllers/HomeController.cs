using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AyncInDotnet.Controllers
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var httpMessage = await client.GetAsync("http://www.filipekberg.se/rss/").ConfigureAwait(false);
                var content = await httpMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                return this.Content(content);
            }
        }
    }
}