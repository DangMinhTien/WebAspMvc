#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Blog_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Blog/Views/Post/Index.cshtml")]
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
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model.Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Menu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae", @"/Areas/Blog/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bbc1c846ebd58e5981fce9a711543b2049fc96420d7ed09ab766eb8ad574c148", @"/Areas/Blog/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Blog_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Bai1_ChinhThuc.Model.Blog.Post>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Paging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Danh sách bài viết";
    var index = ViewBag.PageIndex;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae6490", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = TempData["StatusMessage"];

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
            WriteLiteral("</partial>\r\n<h1>");
#nullable restore
#line 8 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>Tổng số bài viết: ");
#nullable restore
#line 9 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
                Write(ViewBag.totalPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae8724", async() => {
                WriteLiteral("Tạo bài viết mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>STT</th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateUpdated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
            Write(index++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae12529", async() => {
#nullable restore
#line 40 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
                                       WriteLiteral(item.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <br>\r\n                <small>\r\n                    ");
#nullable restore
#line 43 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
               Write(string.Join(",",item.PostCategories.Select(pc => pc.Category.Title)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </small>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateUpdated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae16886", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
                                          WriteLiteral(item.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae19123", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
                                         WriteLiteral(item.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cedee27c72dad4e8808c757f6bf8ef153c41eb4dff158faa3f59666af9ad6aae21633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 66 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
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
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
      
        _AdminSideBarService.SetActive("Post", "Index", "Blog");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 71 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Areas\Blog\Views\Post\Index.cshtml"
Write(Html.Raw(_AdminSideBarService.RenderHtml()));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Bai1_ChinhThuc.Model.Blog.Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
