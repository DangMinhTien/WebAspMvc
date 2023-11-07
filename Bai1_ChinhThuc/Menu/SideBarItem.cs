using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Bai1_ChinhThuc.Menu
{
    public enum SideBarItemType
    {
        Divider,
        Heading,
        NavItem
    }
    public class SideBarItem
    {
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public SideBarItemType Type { get; set;}
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string Page {  get; set; }
        public string AwesomeIcon { get; set; }
        public List<SideBarItem> Items { get; set; }
        public string CollapseId { get; set; }
        public string GetLink(IUrlHelper urlHelper)
        {
            if(Page != null)
            {
                return urlHelper.Page(Page, new {area = Area});
            }
            return urlHelper.Action(Action,Controller, new {area = Area});
        }
        public string RenderHtml(IUrlHelper urlHelper)
        {
            var html = new StringBuilder();
            if(Type == SideBarItemType.Divider)
            {
                html.Append("<hr class=\"sidebar-divider my-2\">");
            }
            else if(Type == SideBarItemType.Heading)
            {
                html.Append(@$"<div class=""sidebar-heading"">
                                {Title}
                            </div>");
            }
            else if(Type == SideBarItemType.NavItem)
            {
                if(Items == null)
                {
                    var icon = (AwesomeIcon != null) ? $"<i class=\"{AwesomeIcon}\"></i>" : "";
                    var cssClass = "nav-item";
                    if (IsActive) cssClass += " active";
                    html.Append($@"<li class=""{cssClass}"">
                                        <a class=""nav-link"" href=""{GetLink(urlHelper)}"">
                                            {icon}
                                            <span>{Title}</span>
                                        </a>
                                    </li>");
                }
                else
                {
                    var icon = (AwesomeIcon != null) ? $"<i class=\"{AwesomeIcon}\"></i>" : "";
                    var cssClass = "nav-link collapsed";
                    if (IsActive) cssClass += " active";
                    var collapCss = "collapse";
                    if (IsActive) collapCss += " show";
                    var itemMenu = "";
                    foreach (var item in Items)
                    {
                        var cssItem = "collapse-item";
                        if (item.IsActive) cssItem += " active";
                        itemMenu += $"<a class=\"{cssItem}\" href=\"{item.GetLink(urlHelper)}\">{item.Title}</a>";
                    }
                    html.Append($@"<li class=""nav-item"">
                                        <a class=""{cssClass}"" href=""#"" data-toggle=""collapse"" data-target=""#{CollapseId}""
                                           aria-expanded=""true"" aria-controls=""{CollapseId}"">
                                            {icon}
                                            <span>{Title}</span>
                                        </a>
                                        <div id=""{CollapseId}"" class=""{collapCss}"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                                            <div class=""bg-white py-2 collapse-inner rounded"">
                                                {itemMenu}
                                            </div>
                                        </div>
                                    </li>");
                }
            }
            return html.ToString();
        }
    }
}
