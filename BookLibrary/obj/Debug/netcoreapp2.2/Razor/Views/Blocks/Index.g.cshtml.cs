#pragma checksum "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01ac057e1330c0baf41907ef6d2aae69fbaf039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blocks_Index), @"mvc.1.0.view", @"/Views/Blocks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blocks/Index.cshtml", typeof(AspNetCore.Views_Blocks_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01ac057e1330c0baf41907ef6d2aae69fbaf039", @"/Views/Blocks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Blocks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookLibrary.Models.Block>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Records", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlockDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRecord", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 32, true);
            WriteLiteral("\r\n<h1>Topic Blocks</h1>\r\n\r\n<p>\r\n");
            EndContext();
#line 10 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
   if (User.IsInRole("Admin"))
  {

#line default
#line hidden
            BeginContext(158, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(162, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf0395749", async() => {
                BeginContext(190, 16, true);
                WriteLiteral("Create New Block");
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
            BeginContext(210, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(214, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(218, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf0397232", async() => {
                BeginContext(242, 25, true);
                WriteLiteral("&nbsp;&nbsp;Edit Comments");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(271, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(278, 87, true);
            WriteLiteral("</p>\r\n<table class=\"a\" >\r\n    <thead>\r\n      <tr>\r\n        <th colspan=\"2\">\r\n          ");
            EndContext();
            BeginContext(366, 41, false);
#line 21 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
     Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(407, 53, true);
            WriteLiteral("\r\n        </th>\r\n        <th colspan=\"3\">\r\n          ");
            EndContext();
            BeginContext(461, 41, false);
#line 24 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
     Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n        </th>\r\n        <th colspan=\"14\" >\r\n          ");
            EndContext();
            BeginContext(558, 40, false);
#line 27 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
     Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(598, 76, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n      </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(706, 60, true);
            WriteLiteral("      <tr>\r\n        <td class=\"but\" colspan=\"2\">\r\n          ");
            EndContext();
            BeginContext(767, 40, false);
#line 36 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(807, 68, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"but\"colspan=\"3\">\r\n          <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 875, "\"", 905, 1);
#line 39 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
WriteAttributeValue("", 881, Url.Content(item.Photo), 881, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(906, 45, true);
            WriteLiteral(" class=\"portrait\" height=\"200\" width=\"200\">\r\n");
            EndContext();
            BeginContext(1008, 97, true);
            WriteLiteral("        </td>\r\n        <td class=\"but\" colspan=\"12\">\r\n          <div class=\"text1\">\r\n            ");
            EndContext();
            BeginContext(1106, 39, false);
#line 44 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 73, true);
            WriteLiteral("\r\n          </div>\r\n        </td>\r\n        <td class=\"but\" colspan=\"2\">\r\n");
            EndContext();
#line 48 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
           if (User.IsInRole("Admin"))
          {

#line default
#line hidden
            BeginContext(1271, 29, true);
            WriteLiteral("          <div>\r\n            ");
            EndContext();
            BeginContext(1300, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf03912626", async() => {
                BeginContext(1355, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
                                        WriteLiteral(item.BlockId);

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
            BeginContext(1363, 49, true);
            WriteLiteral("\r\n          </div>\r\n          <div>\r\n            ");
            EndContext();
            BeginContext(1412, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf03915040", async() => {
                BeginContext(1469, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
#line 54 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
                                          WriteLiteral(item.BlockId);

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
            BeginContext(1479, 20, true);
            WriteLiteral("\r\n          </div>\r\n");
            EndContext();
#line 56 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"

          }

#line default
#line hidden
            BeginContext(1514, 29, true);
            WriteLiteral("          <div>\r\n            ");
            EndContext();
            BeginContext(1543, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf03917726", async() => {
                BeginContext(1601, 7, true);
                WriteLiteral("Details");
                EndContext();
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
#line 59 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
                                           WriteLiteral(item.BlockId);

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
            BeginContext(1612, 49, true);
            WriteLiteral("\r\n          </div>\r\n          <div>\r\n            ");
            EndContext();
            BeginContext(1661, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01ac057e1330c0baf41907ef6d2aae69fbaf03920146", async() => {
                BeginContext(1716, 7, true);
                WriteLiteral("Comment");
                EndContext();
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
#line 62 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
                                        WriteLiteral(item.BlockId);

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
            BeginContext(1727, 62, true);
            WriteLiteral("\r\n          </div>\r\n          \r\n        </td>\r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\tianx\Desktop\cse686\AProject1PersonalWebsite\PersonalWebsite\BookLibrary\Views\Blocks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1792, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookLibrary.Models.Block>> Html { get; private set; }
    }
}
#pragma warning restore 1591
