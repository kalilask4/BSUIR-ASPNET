using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebLabs.Models;

namespace WebLabs.Components
{
    public class MenuViewComponent: ViewComponent
    {
        //Init list menu items
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem{ ControllerName= "Home", PageName= "Index", Text="Lab 3"},
            new MenuItem{ ControllerName="Product", PageName="Index",
                Text="Catalog"},
            new MenuItem{ IsPage=true, AreaName= "Admin", PageName= "/Index",
                Text="Admin"}
        };
        
        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach(var item in _menuItems)
            {
                var _matchController = controller?.Equals(item.ControllerName) ?? false;
                var _matchArea = area?.Equals(item.AreaName) ?? false;
                if(_matchController || _matchArea)
                {
                    item.CssName = "active";
                }
            }
            return View(_menuItems);
        }
    }
}