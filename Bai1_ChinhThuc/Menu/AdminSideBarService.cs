using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Collections.Generic;
using System.Text;

namespace Bai1_ChinhThuc.Menu
{
    public class AdminSideBarService
    {
        private readonly IUrlHelper urlHelper;
        public List<SideBarItem> Items = new List<SideBarItem>();
        public AdminSideBarService(IUrlHelperFactory factory, IActionContextAccessor action)
        {
            urlHelper = factory.GetUrlHelper(action.ActionContext);
            Items.Add(new SideBarItem() { Type = SideBarItemType.Divider });
            Items.Add(new SideBarItem() { Type = SideBarItemType.Heading , Title = "Quản lý chung"});
            Items.Add(new SideBarItem()
            {
                Type = SideBarItemType.NavItem,
                Controller = "DbManage",
                Action = "Index",
                Area = "Database",
                Title = "Quản lý database",
                AwesomeIcon = "fas fa-database"
            });
            Items.Add(new SideBarItem()
            {
                Type = SideBarItemType.NavItem,
                Controller = "Contacts",
                Action = "Index",
                Area = "Contacts",
                Title = "Quản lý liên hệ",
                AwesomeIcon = "fas fa-id-badge"
            });
            Items.Add(new SideBarItem() { Type = SideBarItemType.Divider });
            Items.Add(new SideBarItem()
            {
                Type = SideBarItemType.NavItem,
                Title = "Quyền & thành viên",
                AwesomeIcon = "fas fa-user-tag",
                CollapseId = "RoleAndUser",
                Items = new List<SideBarItem>()
                {
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Page = "/Users/Index",
                        Area = "Admin",
                        Title = "Quản lý người dùng",
                        AwesomeIcon = "fas fa-user"
                    },
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Page = "/Roles/Index",
                        Area = "Admin",
                        Title = "Quản lý quyền",
                        AwesomeIcon = "fas fa-gavel"
                    }
                }
            });

            Items.Add(new SideBarItem() { Type = SideBarItemType.Divider });
            Items.Add(new SideBarItem()
            {
                Type = SideBarItemType.NavItem,
                Title = "Bài viết",
                AwesomeIcon = "fab fa-blogger",
                CollapseId = "Blog",
                Items = new List<SideBarItem>()
                {
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Controller = "Category",
                        Action = "Index",
                        Area = "Blog",
                        Title = "Quản lý chuyên mục",
                        AwesomeIcon = "fas fa-certificate"
                    },
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Controller = "Post",
                        Action = "Index",
                        Area = "Blog",
                        Title = "Quản lý bài viết",
                        AwesomeIcon = "fas fa-blog"
                    }
                }
            });
            Items.Add(new SideBarItem() { Type = SideBarItemType.Divider });
            Items.Add(new SideBarItem()
            {
                Type = SideBarItemType.NavItem,
                Title = "Sản phẩm",
                AwesomeIcon = "fas fa-box",
                CollapseId = "Product",
                Items = new List<SideBarItem>()
                {
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Controller = "CategoryProduct",
                        Action = "Index",
                        Area = "Product",
                        Title = "Quản lý danh mục",
                        AwesomeIcon = "fas fa-certificate"
                    },
                    new SideBarItem()
                    {
                        Type = SideBarItemType.NavItem,
                        Controller = "Product",
                        Action = "Index",
                        Area = "Product",
                        Title = "Quản lý sản phẩm",
                        AwesomeIcon = "fas fa-boxes"
                    }
                }
            });

        }
        public string RenderHtml()
        {
            var html = new StringBuilder();
            foreach (var item in Items)
            {
                html.Append(item.RenderHtml(urlHelper));
            }
            return html.ToString();
        }
        public void SetActive(string Controller, string Action, string Area, string Page = null)
        {
            if(Page != null)
            {
                foreach (var item in Items)
                {
                    if (item.Page == Page && item.Area == Area)
                    {
                        item.IsActive = true;
                        return;
                    }
                    else
                    {
                        if (item.Items != null)
                        {
                            foreach (var childItem in item.Items)
                            {
                                if (childItem.Page == Page && childItem.Area == Area)
                                {
                                    childItem.IsActive = true;
                                    item.IsActive = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var item in Items)
                {
                    if(item.Controller == Controller && item.Action == Action && item.Area == Area)
                    {
                        item.IsActive = true;
                        return;
                    }
                    else
                    {
                        if(item.Items != null)
                        {
                            foreach(var childItem in item.Items)
                            {
                                if (childItem.Controller == Controller && childItem.Action == Action && childItem.Area == Area)
                                {
                                    childItem.IsActive = true;
                                    item.IsActive = true;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
