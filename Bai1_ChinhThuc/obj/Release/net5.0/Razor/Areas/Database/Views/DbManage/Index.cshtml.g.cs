#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2e43559cdc44b2db21e3af9d066777870f699f303305eef7ee52ecf2c5ceae18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Database_Views_DbManage_Index), @"mvc.1.0.view", @"/Areas/Database/Views/DbManage/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
using Bai1_ChinhThuc.Menu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e43559cdc44b2db21e3af9d066777870f699f303305eef7ee52ecf2c5ceae18", @"/Areas/Database/Views/DbManage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6627f1089b58fdb0297d6b331cd18979883968599a298bfb5e786b4fb59088b", @"/Areas/Database/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Database_Views_DbManage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeedData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
  
    ViewData["title"] = "database infor";
    Layout = "/Views/Shared/_LayoutAdmin.cshtml";
    var connect = dbcontext.Database.GetDbConnection();
    var dbName = connect.Database;
    var can_connect = dbcontext.Database.CanConnect();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Thông tin về cơ sở dữ liệu</h2>\r\n<p>");
#nullable restore
#line 18 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
Write(dbName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
Write(connect.DataSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 20 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
Write(connect.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
 foreach(var migration in dbcontext.Database.GetAppliedMigrations())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 24 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
  Write(migration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
 foreach (var migration in dbcontext.Database.GetPendingMigrations())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 29 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
  Write(migration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (pending)</p>\r\n");
#nullable restore
#line 30 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 33 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
 if(!can_connect)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <p>Không có khả nawg kết nối đến Database</p>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
}else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <p>Có khả nawg kết nối đến Database</p>\r\n    </div>\r\n    <h2>Các bảng</h2>\r\n");
#nullable restore
#line 44 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
    await dbcontext.Database.OpenConnectionAsync();
    var tables = dbcontext.Database.GetDbConnection().GetSchema("Tables");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
         foreach(System.Data.DataRow row in tables.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 49 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
           Write(row["TABLE_NAME"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 50 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 52 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e43559cdc44b2db21e3af9d066777870f699f303305eef7ee52ecf2c5ceae1810191", async() => {
                WriteLiteral("\r\n    <button type=\"submit\">Tạo chuyên mục và bài viết</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("SideBar", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
      
        _AdminSideBarService.SetActive("DbManage", "Index", "Database");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
#nullable restore
#line 60 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Areas\Database\Views\DbManage\Index.cshtml"
Write(Html.Raw(_AdminSideBarService.RenderHtml()));

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
        public AppDbContext dbcontext { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
