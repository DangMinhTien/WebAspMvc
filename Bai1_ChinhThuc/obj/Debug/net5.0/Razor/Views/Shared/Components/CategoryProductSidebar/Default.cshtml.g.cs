#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c6fbdafc38f8b11e4ac7e71099a2a91f9d9bc72bfc0b6d5bea235ec7ae98a76c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bai1_ChinhThuc.Pages.Shared.Components.CategoryProductSidebar.Views_Shared_Components_CategoryProductSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryProductSidebar/Default.cshtml")]
namespace Bai1_ChinhThuc.Pages.Shared.Components.CategoryProductSidebar
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
using Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c6fbdafc38f8b11e4ac7e71099a2a91f9d9bc72bfc0b6d5bea235ec7ae98a76c", @"/Views/Shared/Components/CategoryProductSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"968a586b99313b3b5e6fd8bf2b421de287c2c2c7d900bf1458826233699150e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryProductSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar.CategoryProductSidebar.CategoryProductSidebarData>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-categoriesSlug", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
 if(Model.Categories?.Count > 0)
{
    if(Model.lever == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
   Write(Html.Raw("<div class=\"categorysidebar\">"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6fbdafc38f8b11e4ac7e71099a2a91f9d9bc72bfc0b6d5bea235ec7ae98a76c5625", async() => {
                WriteLiteral("\r\n                Tất cả các chuyên mục\r\n            ");
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
            WriteLiteral("\r\n        </h3>\r\n");
#nullable restore
#line 15 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 17 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
         foreach(var category in Model.Categories)
        {
            var cssActive = (category.Slug == Model.categorySlug) ? "active" : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 700, "\"", 708, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6fbdafc38f8b11e4ac7e71099a2a91f9d9bc72bfc0b6d5bea235ec7ae98a76c8666", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
               Write(category.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
AddHtmlAttributeValue("", 738, cssActive, 738, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 21 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
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
#line 25 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
            if(category.CategoryChildren?.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
           Write(await Component.InvokeAsync("Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar.CategoryProductSidebar",
                        new CategoryProductSidebar.CategoryProductSidebarData(){
                            Categories = category.CategoryChildren.ToList(),
                            lever = Model.lever + 1,
                            categorySlug = Model.categorySlug
                        }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
                          

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 37 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
    if (Model.lever == 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\WebAspMvc\Bai1_ChinhThuc\Views\Shared\Components\CategoryProductSidebar\Default.cshtml"
                           
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bai1_ChinhThuc.Views.Shared.Components.CategoryProductSidebar.CategoryProductSidebar.CategoryProductSidebarData> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
