using Bai1_ChinhThuc.Model.Blog;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bai1_ChinhThuc.Views.Shared.Components.CategorySidebar
{
    [ViewComponent]
    public class CategorySidebar : ViewComponent
    {
        public class CategorySidebarData
        {
            public List<Category> Categories { get; set; }
            public int lever { get; set; }
            public string categorySlug { get; set; }
        }
        public IViewComponentResult Invoke(CategorySidebarData data)
        {
            return View(data);
        }
    }
}
