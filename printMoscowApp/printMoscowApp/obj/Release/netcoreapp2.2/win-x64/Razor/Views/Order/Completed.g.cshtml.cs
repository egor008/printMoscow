#pragma checksum "C:\dev\printMoscow\printMoscow\printMoscowApp\printMoscowApp\Views\Order\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216b94540d421647d335fb7bcb3d0593524bfda2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Completed), @"mvc.1.0.view", @"/Views/Order/Completed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Completed.cshtml", typeof(AspNetCore.Views_Order_Completed))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216b94540d421647d335fb7bcb3d0593524bfda2", @"/Views/Order/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd59fbd8e2602ce86f040d915655bcdcd4922eac", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Completed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 113, true);
            WriteLiteral("<h2>Спасибо!</h2>\r\n<p>\r\n\tCпасибо за оформление заказа.\r\n</p>\r\n<p>\r\n\tМы отправим ваш товар как можно скорее.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
