using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webhook.Models;

namespace webhook.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        public IActionResult HandleWebhook([FromBody] string data)
        {
            // Do something with the data received in the webhook
            return Ok("Webhook received");
        }
    }

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
