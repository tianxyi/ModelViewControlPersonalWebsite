#pragma checksum "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510455cb07d328a909c76501f68687b4c1a249a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blocks_Records), @"mvc.1.0.view", @"/Views/Blocks/Records.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blocks/Records.cshtml", typeof(AspNetCore.Views_Blocks_Records))]
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
#line 1 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#line 2 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510455cb07d328a909c76501f68687b4c1a249a8", @"/Views/Blocks/Records.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Blocks_Records : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookLibrary.Models.Record>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
  
    ViewData["Title"] = "Records";

#line default
#line hidden
            BeginContext(90, 22, true);
            WriteLiteral("\r\n<h1>Records</h1>\r\n\r\n");
            EndContext();
            BeginContext(177, 72, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n      <tr>\r\n        <th>\r\n          ");
            EndContext();
            BeginContext(250, 43, false);
#line 15 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(293, 41, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
            EndContext();
            BeginContext(335, 41, false);
#line 18 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayNameFor(model => model.Block));

#line default
#line hidden
            EndContext();
            BeginContext(376, 41, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
            EndContext();
            BeginContext(418, 40, false);
#line 21 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(458, 41, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n          ");
            EndContext();
            BeginContext(500, 40, false);
#line 24 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
            EndContext();
            BeginContext(540, 76, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n      </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(665, 71, true);
            WriteLiteral("      <tr>\r\n        <td class=\"cc\" style=\"padding: 0.1em;\">\r\n          ");
            EndContext();
            BeginContext(737, 42, false);
#line 34 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(779, 76, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"cc\" style=\"padding: 0.1em;\">\r\n          ");
            EndContext();
            BeginContext(856, 46, false);
#line 37 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayFor(modelItem => item.Block.Title));

#line default
#line hidden
            EndContext();
            BeginContext(902, 76, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"cc\" style=\"padding: 0.1em;\">\r\n          ");
            EndContext();
            BeginContext(979, 39, false);
#line 40 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 76, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"cc\" style=\"padding: 0.1em;\">\r\n          ");
            EndContext();
            BeginContext(1095, 39, false);
#line 43 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
     Write(Html.DisplayFor(modelItem => item.Time));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 76, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"cc\" style=\"padding: 0.1em;\">\r\n          ");
            EndContext();
            BeginContext(1210, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "510455cb07d328a909c76501f68687b4c1a249a88628", async() => {
                BeginContext(1267, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
                                       WriteLiteral(item.RecordId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1275, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1363, 10, true);
            WriteLiteral("          ");
            EndContext();
            BeginContext(1373, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "510455cb07d328a909c76501f68687b4c1a249a811104", async() => {
                BeginContext(1432, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
                                         WriteLiteral(item.RecordId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1442, 30, true);
            WriteLiteral("\r\n        </td>\r\n      </tr>\r\n");
            EndContext();
#line 51 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Records.cshtml"
        }

#line default
#line hidden
            BeginContext(1483, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1520, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "510455cb07d328a909c76501f68687b4c1a249a813816", async() => {
                BeginContext(1542, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookLibrary.Models.Record>> Html { get; private set; }
    }
}
#pragma warning restore 1591
