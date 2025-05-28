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
}
