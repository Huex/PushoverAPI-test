using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Net;

namespace PushoverTest.Controllers
{
    [Route("api/[controller]")]
    public class PushoverController : Controller
    {
        // POST api/pushover
        [HttpPost]
        public void Post([FromBody] PushoverMessage value) =>
            new WebClient().UploadValues("https://api.pushover.net/1/messages.json",
                new NameValueCollection {
                    { "token", value.Token },
                    { "user", value.User },
                    { "message", value.Message } });
    }
}
