#pragma checksum "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e97f251b38702fcca038382e09200c2edadf422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blocks_BlockDetails), @"mvc.1.0.view", @"/Views/Blocks/BlockDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blocks/BlockDetails.cshtml", typeof(AspNetCore.Views_Blocks_BlockDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e97f251b38702fcca038382e09200c2edadf422", @"/Views/Blocks/BlockDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Blocks_BlockDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookLibrary.Models.Block>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
  
  ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(76, 33, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div>\r\n  <h3>");
            EndContext();
            BeginContext(110, 37, false);
#line 9 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
 Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(147, 24, true);
            WriteLiteral("</h3>\r\n</div>\r\n<div>\r\n  ");
            EndContext();
            BeginContext(172, 41, false);
#line 12 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(213, 9, true);
            WriteLiteral("\r\n  :\r\n  ");
            EndContext();
            BeginContext(223, 37, false);
#line 14 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(260, 51, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div class=\"detail\">\r\n  <pre>\r\n  ");
            EndContext();
            BeginContext(312, 36, false);
#line 19 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(348, 85, true);
            WriteLiteral("\r\n  </pre>\r\n</div>\r\n\r\n<div style=\"margin-top:15px;\">\r\n  <img height=\"600\" width=\"800\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 433, "\"", 464, 1);
#line 24 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
WriteAttributeValue("", 439, Url.Content(Model.Photo), 439, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(465, 233, true);
            WriteLiteral(">\r\n</div>\r\n\r\n\r\n\r\n\r\n<sizerbutton-container>\r\n  <sizer-button onclick=\"biggerImage(\'theImage\')\">+</sizer-button>\r\n  <sizer-button onclick=\"smallerImage(\'theImage\')\">-</sizer-button>\r\n  <sizer-button onclick=\"add2(1)\">h</sizer-button>\r\n");
            EndContext();
            BeginContext(823, 86, true);
            WriteLiteral("</sizerbutton-container>\r\n\r\n<div style=\"margin-top:15px; margin-bottom:15px\" >\r\n  <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 909, "\"", 942, 1);
#line 40 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
WriteAttributeValue("", 915, Url.Content(Model.Diagram), 915, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 138, true);
            WriteLiteral(" id=\"theImage\">\r\n</div>\r\n<div>\r\n  <h4 style=\"margin-bottom: 10px;\">Comments</h4>\r\n</div>\r\n\r\n<table style=\"color:black;font-size:small\" >\r\n");
            EndContext();
#line 47 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
   foreach (var lct in Model.Records)//models has lecture collections one to many many to many  many to many is two one to many
  {

#line default
#line hidden
            BeginContext(1215, 93, true);
            WriteLiteral("    <tr style=\"border-bottom:1px solid #993333;\" >\r\n      <td style=\"float:left\" ;>\r\n        ");
            EndContext();
            BeginContext(1309, 23, false);
#line 51 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
   Write(Html.Label(lct.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 60, true);
            WriteLiteral("\r\n      </td>\r\n\r\n\r\n      <td style=\"float:right;\">\r\n        ");
            EndContext();
            BeginContext(1393, 19, false);
#line 56 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
   Write(Html.Name(lct.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1423, 52, false);
#line 57 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
   Write(Html.Label(lct.Time.ToString("HH:mm:ss MM-dd-yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 30, true);
            WriteLiteral("\r\n      </td>\r\n\r\n\r\n    </tr>\r\n");
            EndContext();
#line 62 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
  }

#line default
#line hidden
            BeginContext(1510, 23, true);
            WriteLiteral("</table>\r\n\r\n\r\n<div>\r\n\r\n");
            EndContext();
#line 68 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
   if (User.IsInRole("Admin"))
  {

#line default
#line hidden
            BeginContext(1570, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1574, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e97f251b38702fcca038382e09200c2edadf42210128", async() => {
                BeginContext(1630, 5, true);
                WriteLiteral("Edit ");
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
#line 70 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
                                WriteLiteral(Model.BlockId);

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
            BeginContext(1639, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 71 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
  }

#line default
#line hidden
            BeginContext(1646, 18, true);
            WriteLiteral("  &nbsp;&nbsp;\r\n  ");
            EndContext();
            BeginContext(1664, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e97f251b38702fcca038382e09200c2edadf42212776", async() => {
                BeginContext(1720, 9, true);
                WriteLiteral("Comment  ");
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
#line 73 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\BlockDetails.cshtml"
                              WriteLiteral(Model.BlockId);

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
            BeginContext(1733, 20, true);
            WriteLiteral("\r\n  &nbsp;&nbsp;\r\n  ");
            EndContext();
            BeginContext(1753, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e97f251b38702fcca038382e09200c2edadf42215162", async() => {
                BeginContext(1775, 4, true);
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
            BeginContext(1783, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Models.Block> Html { get; private set; }
    }
}
#pragma warning restore 1591
