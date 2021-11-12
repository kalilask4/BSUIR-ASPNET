using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebLabs.Models;

namespace WebLabs.Components
{
    public class MenuViewComponent: ViewComponent
    {
        //Init list menu items
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem{ Controller= "Home", Page= "Index", Text="Lab 3"},
            new MenuItem{ Controller="Product", Page="Index",
                Text="Catalog"},
            new MenuItem{ IsPage=true, Area= "Admin", Page= "/Index",
                Text="Admin"}
        };
        
        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach(var item in _menuItems)
            {
                var _matchController = controller?.Equals(item.Controller) ?? false;
                var _matchArea = area?.Equals(item.Area) ?? false;
                if(_matchController || _matchArea)
                {
                    item.Active = "active";
                }
            }
            return View(_menuItems);
        }
    }
}