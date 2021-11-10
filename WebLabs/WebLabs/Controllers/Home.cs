using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebLabs.Controllers
{
    public class Home : Controller
    {
        private List<ListDemo> _listDemo;
        
        public Home()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
        }
        
        // GET
        public IActionResult Index()
        {
            ViewData["Lst"] =
                new SelectList(_listDemo,"ListItemValue","ListItemText");
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
        
        // public IActionResult Index()
        // {
        //     ViewBag.Text = "Lab 2";
        //     return View();
        // }
        
    }
}