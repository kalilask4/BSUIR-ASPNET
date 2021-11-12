namespace WebLabs.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        //page or method
        public bool IsPage { get; set; } = false;
        public  string Controller { get; set; }
        // controller action
        public  string Action { get; set; }
        public  string Page { get; set; }
        // Area name
        public  string Area { get; set; }
        // class CSS for current menu item
        public  string Active { get; set; }
        
    }
}