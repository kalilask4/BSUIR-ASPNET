using Microsoft.AspNetCore.Mvc;

namespace WebLabs.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {
            ViewData["Text"] = "Lab 2";
            return View();
        }
        
        
        // [ViewData]
        // public string Text { get; set; }
        // public IActionResult Index()
        // {
        //     Text = "Lab 2";
        //     return View();
        // }
        
    }
}