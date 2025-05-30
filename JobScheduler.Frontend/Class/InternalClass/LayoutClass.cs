using Microsoft.AspNetCore.Components.Routing;

namespace JobScheduler.Frontend.Class.InternalClass
{
    public class NavItem
    {
        public string Title { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Href { get; set; } = "";
        public NavLinkMatch Match { get; set; } = NavLinkMatch.Prefix;
    }
    public class TableAction<T>
    {
        public string Label { get; set; }
        public string CssClass { get; set; }
        public Action<T> Callback { get; set; }
    }

}
