#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Blog_Views_ViewPost_Index), @"mvc.1.0.view", @"/Areas/Blog/Views/ViewPost/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
using Bai1_ChinhThuc.Model.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
using Bai1_ChinhThuc.Views.Shared.Components.CategorySidebar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d633", @"/Areas/Blog/Views/ViewPost/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bbc1c846ebd58e5981fce9a711543b2049fc96420d7ed09ab766eb8ad574c148", @"/Areas/Blog/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Blog_Views_ViewPost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Paging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
  
    List<Category> categories = ViewBag.categories as List<Category>;
    Category category = ViewBag.category as Category;
    ViewData["Title"] = (category != null) ? category.Title : "Bài viết trong tất cả các chuyên mục";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 9 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
 if(category != null)
{
    var lstParent = category.GetParents();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav style=\"--bs-breadcrumb-divider: \'>\';\" aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n");
#nullable restore
#line 15 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
             foreach(var cate in lstParent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d6337256", async() => {
#nullable restore
#line 18 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
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
#line 18 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
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
#line 20 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"breadcrumb-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d63310525", async() => {
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
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
#line 23 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
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
            WriteLiteral("\r\n            </li>\r\n        </ol>\r\n    </nav>\r\n    <hr />\r\n");
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
Write(Html.Raw(category.Decreption));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Bài viết trong tất cả các chuyên mục...</p>\r\n");
#nullable restore
#line 33 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n\r\n");
#nullable restore
#line 36 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
 foreach(var post in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""d-flex border-bottom mb-3 pb-3"">
        <div class=""flex-shrink-0 w-25"">
            <img src=""/contents/No_Image_Available.jpg"" class=""w-100"" alt=""Sample Image"">
        </div>
        <div class=""flex-grow-1 ms-3"">
            <h5>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d63314904", async() => {
#nullable restore
#line 44 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                                                                                                             Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postSlug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                                                                                          WriteLiteral(post.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postSlug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postSlug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postSlug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <small class=\"text-muted\"><i>Posted on ");
#nullable restore
#line 45 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                                                  Write(post.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></small>\r\n            </h5>\r\n            <p>");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
          Write(post.Decerption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Chủ đề: <span class=\"title-category\">");
#nullable restore
#line 48 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                                               Write(post.PostCategories.FirstOrDefault()?.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n            <div class=\"author-row\">\r\n                Tác giả: <strong>");
#nullable restore
#line 50 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                            Write(post.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> |\r\n                Ngày cập nhật: <i>");
#nullable restore
#line 51 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
                             Write(post.DateUpdated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c85b81e85cd0302ebf07383226710eb8530afa518dc27db49011f456628d63319999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 56 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
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
#line 58 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\ViewPost\Index.cshtml"
Write(await Component.InvokeAsync("Bai1_ChinhThuc.Views.Shared.Components.CategorySidebar.CategorySidebar",
                new CategorySidebar.CategorySidebarData(){
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591