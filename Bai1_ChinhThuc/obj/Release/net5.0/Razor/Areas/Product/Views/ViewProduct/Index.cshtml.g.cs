#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Product_Views_ViewProduct_Index), @"mvc.1.0.view", @"/Areas/Product/Views/ViewProduct/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
using Bai1_ChinhThuc.Model.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
using Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f58", @"/Areas/Product/Views/ViewProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"38ee90b3994a6e386c28ad7a6714480f0cc284330b2080e2473ea75bac7ccd36", @"/Areas/Product/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Product_Views_ViewProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-categoriesSlug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Paging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
  
    List<CategoryProduct> categories = ViewBag.categories as List<CategoryProduct>;
    CategoryProduct category = ViewBag.category as CategoryProduct;
    ViewData["Title"] = (category != null) ? category.Title : "Sản phẩm trong tất cả các chuyên mục";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 9 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<nav style=\"--bs-breadcrumb-divider: \'>\';\" aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f588381", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoriesSlug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoriesSlug"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 16 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
         if(category != null)
        {
            var lstParent = category.GetParents();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
             foreach(var cate in lstParent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f5811184", async() => {
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                                                            Write(cate.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoriesSlug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                                         WriteLiteral(cate.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoriesSlug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoriesSlug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoriesSlug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 24 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"breadcrumb-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f5814495", async() => {
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                                                            Write(category.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoriesSlug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                                     WriteLiteral(category.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoriesSlug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoriesSlug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoriesSlug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 29 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n</nav>\r\n");
#nullable restore
#line 32 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 35 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
Write(Html.Raw(category.Decreption));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Sản Phẩm trong tất cả các thể loại...</p>\r\n");
#nullable restore
#line 40 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div class=\"d-flex flex-wrap justify-content-between\">\r\n");
#nullable restore
#line 43 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
 foreach(var product in Model)
{
        var srcImg = "/contents/No_Image_Available.jpg";
        if(product.Photos.Count() > 0)
        {
            srcImg = "/contents/Products/" + product.Photos.FirstOrDefault()?.FileName;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" style=\"width: 32%;\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1871, "\"", 1884, 1);
#nullable restore
#line 51 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
WriteAttributeValue("", 1877, srcImg, 1877, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 53 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                              Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 54 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                            Write(product.Decerption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Chủ đề: <strong>");
#nullable restore
#line 55 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                          Write(product.ProductCategoryProducts.FirstOrDefault()?.CategoryProduct.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <p>Giá: <strong class=\"text-danger\">");
#nullable restore
#line 56 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f5821523", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productSlug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                              WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productSlug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productSlug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productSlug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f5824303", async() => {
                WriteLiteral("Đặt hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
                                               WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3c799c77b43cb29e4af844cdb4f163aac3cea7c4bacec205eaa25a5e7ed5f5827353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 67 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ViewBag.pagingmodel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 69 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Index.cshtml"
Write(await Component.InvokeAsync("Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar.CategoryProductSidebar",
                new CategoryProductSidebar.CategoryProductSidebarData(){
                    Categories = categories,
                    lever = 0,
                    categorySlug = ViewBag.categoriesSlug
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AdminSideBarService _AdminSideBarService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
