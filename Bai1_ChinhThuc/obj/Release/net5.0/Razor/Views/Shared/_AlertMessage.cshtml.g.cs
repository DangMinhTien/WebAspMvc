#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1f4670d15252302df2b4fc8e73bc9cef3c6da241b064751956651c0455deed05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bai1_ChinhThuc.Pages.Shared.Views_Shared__AlertMessage), @"mvc.1.0.view", @"/Views/Shared/_AlertMessage.cshtml")]
namespace Bai1_ChinhThuc.Pages.Shared
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\_ViewImports.cshtml"
using Bai1_ChinhThuc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1f4670d15252302df2b4fc8e73bc9cef3c6da241b064751956651c0455deed05", @"/Views/Shared/_AlertMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"968a586b99313b3b5e6fd8bf2b421de287c2c2c7d900bf1458826233699150e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AlertMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
  
    var thongbao = TempData["thongbao"] as string;
    var status = TempData["status"] as string;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
 if(!string.IsNullOrEmpty(thongbao))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <p>");
#nullable restore
#line 8 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
      Write(thongbao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
 if (!string.IsNullOrEmpty(status))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <p>");
#nullable restore
#line 14 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
      Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\LENOVO\OneDrive\Documents\Wordspace\AspNet\MVC\Bai1_ChinhThuc\Bai1_ChinhThuc\Views\Shared\_AlertMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
