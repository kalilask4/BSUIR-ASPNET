namespace WebLabs.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        //страница или метод контроллера
        public bool IsPage { get; set; } = false;
        public  string ControllerName { get; set; }
        // имя действия контроллера
        public  string MethodName { get; set; }
        // имя действия контроллера
        public  string PageName { get; set; }
        // имя области
        public  string AreaName { get; set; }
        // класс CSS для текущего пункта меню
        public  string CssName { get; set; }
        
    }
}