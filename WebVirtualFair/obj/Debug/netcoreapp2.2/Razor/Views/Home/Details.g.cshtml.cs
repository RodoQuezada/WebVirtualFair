#pragma checksum "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df738b1cd1a4ed9e10e1dc32798b7948dcf678ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/_ViewImports.cshtml"
using WebVirtualFair;

#line default
#line hidden
#line 2 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/_ViewImports.cshtml"
using WebVirtualFair.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df738b1cd1a4ed9e10e1dc32798b7948dcf678ea", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bda08db3313bb05d9342b20f90c6c1c58306ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(79, 142, true);
            WriteLiteral("\n<h1> Details </h1>\n\n<div class=\"container\">\n    <h4>User Data</h4>\n    <hr/>\n    <dl class=\"row\">\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(222, 38, false);
#line 16 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(260, 59, true);
            WriteLiteral("\n        </dt>\n\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(320, 34, false);
#line 20 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(354, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(412, 40, false);
#line 23 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(452, 59, true);
            WriteLiteral("\n        </dt>\n\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(512, 36, false);
#line 27 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(548, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(606, 44, false);
#line 30 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(650, 59, true);
            WriteLiteral("\n        </dt>\n\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(710, 40, false);
#line 34 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(750, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(809, 48, false);
#line 38 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.veryLastName));

#line default
#line hidden
            EndContext();
            BeginContext(857, 59, true);
            WriteLiteral("\n        </dt>\n\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(917, 44, false);
#line 42 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.veryLastName));

#line default
#line hidden
            EndContext();
            BeginContext(961, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1019, 45, false);
#line 45 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.birthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1123, 41, false);
#line 48 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.birthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1223, 44, false);
#line 52 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1326, 40, false);
#line 55 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.idNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1425, 48, false);
#line 59 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idNumberType));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1532, 44, false);
#line 62 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.idNumberType));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1635, 41, false);
#line 66 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1735, 37, false);
#line 69 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1831, 41, false);
#line 73 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1931, 37, false);
#line 76 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1968, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2027, 44, false);
#line 80 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2130, 40, false);
#line 83 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2229, 42, false);
#line 87 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2330, 38, false);
#line 90 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2427, 52, false);
#line 94 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.passwordRecovery));

#line default
#line hidden
            EndContext();
            BeginContext(2479, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2538, 48, false);
#line 97 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.passwordRecovery));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2645, 45, false);
#line 101 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.createdAt));

#line default
#line hidden
            EndContext();
            BeginContext(2690, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2749, 41, false);
#line 104 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.createdAt));

#line default
#line hidden
            EndContext();
            BeginContext(2790, 66, true);
            WriteLiteral("\n        </dd>\n        \n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2857, 44, false);
#line 108 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.updateAt));

#line default
#line hidden
            EndContext();
            BeginContext(2901, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2960, 40, false);
#line 111 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.updateAt));

#line default
#line hidden
            EndContext();
            BeginContext(3000, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3059, 47, false);
#line 115 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.companyName));

#line default
#line hidden
            EndContext();
            BeginContext(3106, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3165, 43, false);
#line 118 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.companyName));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3267, 49, false);
#line 122 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idCompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(3316, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3375, 45, false);
#line 125 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.idCompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(3420, 66, true);
            WriteLiteral("\n        </dd>\n        \n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3487, 44, false);
#line 129 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.position));

#line default
#line hidden
            EndContext();
            BeginContext(3531, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3590, 40, false);
#line 132 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.position));

#line default
#line hidden
            EndContext();
            BeginContext(3630, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3689, 52, false);
#line 136 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.comercialAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3741, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3800, 48, false);
#line 139 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.comercialAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3848, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3907, 48, false);
#line 143 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.companyPhone));

#line default
#line hidden
            EndContext();
            BeginContext(3955, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4014, 44, false);
#line 146 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.companyPhone));

#line default
#line hidden
            EndContext();
            BeginContext(4058, 58, true);
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4117, 48, false);
#line 150 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.companyEmail));

#line default
#line hidden
            EndContext();
            BeginContext(4165, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4224, 44, false);
#line 153 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Home/Details.cshtml"
       Write(Html.DisplayFor(model => model.companyEmail));

#line default
#line hidden
            EndContext();
            BeginContext(4268, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(4310, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df738b1cd1a4ed9e10e1dc32798b7948dcf678ea20214", async() => {
                BeginContext(4332, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4348, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonData> Html { get; private set; }
    }
}
#pragma warning restore 1591
