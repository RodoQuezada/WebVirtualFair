#pragma checksum "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19733e2b6f35de29ce6017ba47e63b2eace2ff61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_List), @"mvc.1.0.view", @"/Views/Person/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/List.cshtml", typeof(AspNetCore.Views_Person_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19733e2b6f35de29ce6017ba47e63b2eace2ff61", @"/Views/Person/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bda08db3313bb05d9342b20f90c6c1c58306ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebVirtualFair.Models.PersonData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 27, true);
            WriteLiteral("\n<h1> Index </h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(119, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19733e2b6f35de29ce6017ba47e63b2eace2ff613743", async() => {
                BeginContext(142, 11, true);
                WriteLiteral(" Create New");
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
            BeginContext(157, 75, true);
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <thead>\n    <tr>\n        <th>\n            ");
            EndContext();
            BeginContext(233, 38, false);
#line 17 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(271, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(312, 40, false);
#line 20 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(352, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(393, 44, false);
#line 23 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
       Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(437, 40, true);
            WriteLiteral("\n        </th>\n        <th>\n            ");
            EndContext();
            BeginContext(478, 48, false);
#line 26 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
       Write(Html.DisplayNameFor(model => model.veryLastName));

#line default
#line hidden
            EndContext();
            BeginContext(526, 68, true);
            WriteLiteral("\n        </th>\n        <th></th>\n    </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 32 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(633, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(680, 37, false);
#line 36 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(717, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(770, 39, false);
#line 39 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(809, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(862, 43, false);
#line 42 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.DisplayFor(modelItem => item.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(905, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(958, 47, false);
#line 45 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.DisplayFor(modelItem => item.veryLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1058, 55, false);
#line 48 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.ActionLink("Update", "Update", new {id = item.id}));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1133, 57, false);
#line 49 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.ActionLink("Details", "Details", new {id = item.id}));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1210, 55, false);
#line 50 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {id = item.id}));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 35, true);
            WriteLiteral(" |\n            </td>\n        </tr>\n");
            EndContext();
#line 53 "/Users/ro/RiderProjects/WebVirtualFair/WebVirtualFair/Views/Person/List.cshtml"
    }

#line default
#line hidden
            BeginContext(1306, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebVirtualFair.Models.PersonData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
