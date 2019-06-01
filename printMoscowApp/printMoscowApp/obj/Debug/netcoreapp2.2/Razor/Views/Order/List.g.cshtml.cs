#pragma checksum "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d99d7bebc970c7624fe401599e1d9f9d8f1f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\_ViewImports.cshtml"
using PrintMoscowApp.Models;

#line default
#line hidden
#line 2 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\_ViewImports.cshtml"
using PrintMoscowApp.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\_ViewImports.cshtml"
using PrintMoscowApp.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d99d7bebc970c7624fe401599e1d9f9d8f1f26", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd59fbd8e2602ce86f040d915655bcdcd4922eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
  
	ViewBag.Title = "Orders";
	Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
            BeginContext(123, 128, true);
            WriteLiteral("\t<table class=\"table table-bordered table-striped\">\r\n\t\t<tr><th>Name</th><th>Zip</th><th colspan=\"2\">Details</th><th></th></tr>\r\n");
            EndContext();
#line 13 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
         foreach (Order o in Model)
		{

#line default
#line hidden
            BeginContext(287, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(305, 6, false);
#line 16 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
               Write(o.Name);

#line default
#line hidden
            EndContext();
            BeginContext(311, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(327, 5, false);
#line 17 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
               Write(o.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(332, 67, true);
            WriteLiteral("</td>\r\n\t\t\t\t<th>Product</th>\r\n\t\t\t\t<th>Quantity</th>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(399, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d99d7bebc970c7624fe401599e1d9f9d8f1f265893", async() => {
                BeginContext(444, 43, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"orderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 487, "\"", 505, 1);
#line 22 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
WriteAttributeValue("", 495, o.OrderID, 495, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(506, 100, true);
                WriteLiteral(" />\r\n\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n\t\t\t\t\t\t\tShip\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(613, 23, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 29 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
             foreach (CartLine line in o.Lines)
			{

#line default
#line hidden
            BeginContext(682, 47, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td colspan=\"2\"></td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(730, 17, false);
#line 33 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
                   Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(747, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(764, 13, false);
#line 34 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(777, 34, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td></td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 37 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"

			}

#line default
#line hidden
#line 38 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
             
		}

#line default
#line hidden
            BeginContext(824, 11, true);
            WriteLiteral("\t</table>\r\n");
            EndContext();
#line 41 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(847, 53, true);
            WriteLiteral("\t<div class=\"text-center\">No Unshipped Orders</div>\r\n");
            EndContext();
#line 45 "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
