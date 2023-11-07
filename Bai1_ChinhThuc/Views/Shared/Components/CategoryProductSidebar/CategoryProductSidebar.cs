using Bai1_ChinhThuc.Model.Blog;
using Bai1_ChinhThuc.Model.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar
{
    [ViewComponent]
    public class CategoryProductSidebar : ViewComponent
    {
        public class CategoryProductSidebarData
        {
            public List<CategoryProduct> Categories { get; set; }
            public int lever { get; set; }
            public string categorySlug { get; set; }
        }
        public IViewComponentResult Invoke(CategoryProductSidebarData data)
        {
            return View(data);
        }
    }
}
