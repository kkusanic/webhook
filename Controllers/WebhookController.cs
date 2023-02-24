using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webhook.Controllers
{

    [Route("[controller]")]
    public class WebhookController : Controller
    {
        private readonly ILogger<WebhookController> _logger;

        [HttpPost]
        public IActionResult HandleWebhook([FromBody] string data)
        {
            // Do something with the data received in the webhook
            return Ok("Webhook received");
        }

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}