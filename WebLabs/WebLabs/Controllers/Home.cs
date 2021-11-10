using Microsoft.AspNetCore.Mvc;

namespace WebLabs.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}