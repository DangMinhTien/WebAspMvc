#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Product_Views_ViewProduct_Details), @"mvc.1.0.view", @"/Areas/Product/Views/ViewProduct/Details.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
using Bai1_ChinhThuc.Model.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
using Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c", @"/Areas/Product/Views/ViewProduct/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"38ee90b3994a6e386c28ad7a6714480f0cc284330b2080e2473ea75bac7ccd36", @"/Areas/Product/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Product_Views_ViewProduct_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bai1_ChinhThuc.Model.Product.ProductModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-categoriesSlug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
  
    List<CategoryProduct> categories = ViewBag.categories as List<CategoryProduct>;
    CategoryProduct category = ViewBag.category as CategoryProduct;
    ViewData["title"] = Model.Title;
    var otherproduct = ViewBag.otherproduct as List<ProductModel>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav style=\"--bs-breadcrumb-divider: \'>\';\" aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c7322", async() => {
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
#line 16 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
         if (category != null)
        {
            var lstParent = category.GetParents();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
             foreach (var cate in lstParent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"breadcrumb-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c10145", async() => {
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 23 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 25 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"breadcrumb-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c13445", async() => {
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 28 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
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
#line 30 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n</nav>\r\n<hr />\r\n<div class=\"detailpost\">\r\n    <h1>");
#nullable restore
#line 35 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"sapo\">\r\n        ");
#nullable restore
#line 37 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
   Write(Model.Decerption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <p>Giá: <strong>");
#nullable restore
#line 40 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c17688", async() => {
                WriteLiteral("Đặt hàng");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                                       WriteLiteral(Model.ProductId);

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
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <i>Cập nhật: ");
#nullable restore
#line 45 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                Write(Model.DateUpdated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    </div>\r\n    <div id=\"box-photo-upload\" class=\"d-flex flex-wrap photo-upload\" data-id=\"");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                                                                         Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n    </div>\r\n    <hr />\r\n    ");
#nullable restore
#line 51 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 54 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
Write(await Component.InvokeAsync("Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar.CategoryProductSidebar",
                new CategoryProductSidebar.CategoryProductSidebarData(){
                    Categories = categories,
                    lever = 0,
                    categorySlug = category?.Slug
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <ul class=\"list-group\">\r\n");
#nullable restore
#line 61 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
             foreach(var product in otherproduct)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"list-group-item\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c9430cf5f878b8cda24744cd79d6b89fe6d8e5d40ac68f2dcd914a8f03a303c22672", async() => {
#nullable restore
#line 64 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                                                                                                                             Write(product.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
#line 64 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
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
                WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 66 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function LoadPhoto() {
            var box = $(""#box-photo-upload"")
            var ProductID = box.data(""id"")
            box.empty()
            var formData = new FormData();
            formData.append(""id"", ProductID)
            var urlListPhoto = """);
#nullable restore
#line 77 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Product\Views\ViewProduct\Details.cshtml"
                           Write(Url.Action("ListPhoto"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            $.ajax({
                data: formData,
                catch: false,
                url: urlListPhoto,
                type: ""POST"",
                contentType: false,
                processData: false,
                success: function (data) {
                    if (data.success == 1) {
                        data.photos.forEach((item) => {
                            var e = $(`<div class=""photodetail w-25 p-1"">
                                            <img style=""object-fit:contain"" class=""w-100 h-100 img-thumbnail"" src=""${item.path}"" />
                                      </div>`)
                            box.append(e)
                        })
                    }
                }
            })

            //console.log(ProductID)
        }
        $(document).ready(function(){
            LoadPhoto()
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bai1_ChinhThuc.Model.Product.ProductModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
