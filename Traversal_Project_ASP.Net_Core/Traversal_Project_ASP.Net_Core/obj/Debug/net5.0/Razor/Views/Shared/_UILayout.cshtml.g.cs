#pragma checksum "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a6ad034d666b11bac1b40d1ca19614a8be1b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UILayout), @"mvc.1.0.view", @"/Views/Shared/_UILayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\_ViewImports.cshtml"
using Traversal_Project_ASP.Net_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\_ViewImports.cshtml"
using Traversal_Project_ASP.Net_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a6ad034d666b11bac1b40d1ca19614a8be1b58", @"/Views/Shared/_UILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef8ddcd42b4877fdec9ce3e243eafca0909b12", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"zxx\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("~/Views/LayoutPartial/_HeaderPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a6ad034d666b11bac1b40d1ca19614a8be1b584026", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 12 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("~/Views/LayoutPartial/_NavbarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 14 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("~/Views/LayoutPartial/_FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 18 "C:\Users\Ertugrul\Documents\GitHub\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Traversal_Project_ASP.Net_Core\Views\Shared\_UILayout.cshtml"
Write(await Html.PartialAsync("~/Views/LayoutPartial/_ScriptsPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
