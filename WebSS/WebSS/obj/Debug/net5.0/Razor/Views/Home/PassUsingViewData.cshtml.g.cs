#pragma checksum "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58416ae3d6f5a40322f46c65c8dd63d753b3e808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PassUsingViewData), @"mvc.1.0.view", @"/Views/Home/PassUsingViewData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58416ae3d6f5a40322f46c65c8dd63d753b3e808", @"/Views/Home/PassUsingViewData.cshtml")]
    public class Views_Home_PassUsingViewData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
  
    Layout = null;
    var rand = @ViewData["Rand"] as WebSS.Services.Pass;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58416ae3d6f5a40322f46c65c8dd63d753b3e8084229", async() => {
                WriteLiteral("\r\n    <title>Home Page</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58416ae3d6f5a40322f46c65c8dd63d753b3e8084620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58416ae3d6f5a40322f46c65c8dd63d753b3e8086589", async() => {
                WriteLiteral("\r\n    <header>\r\n        <p>WebSS</p>\r\n        <p><a href=\"/Home\">Home</a></p>\r\n    </header>\r\n    <div class=\"main\">\r\n        <h1>PassUsingViewData</h1>\r\n        <p class=\"navbar-brand\">\r\n            <b>Rand Value First: ");
#nullable restore
#line 22 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                            Write(rand.f);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n        </p>\r\n        <p>\r\n            <b>Rand Value Second: ");
#nullable restore
#line 25 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                             Write(rand.s);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n        </p>\r\n        <p>\r\n            <b>Add:</b>\r\n        </p>\r\n        <p> ");
#nullable restore
#line 30 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
       Write(rand.f);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + ");
#nullable restore
#line 30 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                 Write(rand.s);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = ");
#nullable restore
#line 30 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                           Write(rand.add());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>\r\n            <b>Sub:</b>\r\n        </p>\r\n        <p> ");
#nullable restore
#line 34 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
       Write(rand.f);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 34 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                 Write(rand.s);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = ");
#nullable restore
#line 34 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                           Write(rand.sub());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>\r\n            <b>Mult:</b>\r\n        </p>\r\n        <p> ");
#nullable restore
#line 38 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
       Write(rand.f);

#line default
#line hidden
#nullable disable
                WriteLiteral(" * ");
#nullable restore
#line 38 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                 Write(rand.s);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = ");
#nullable restore
#line 38 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                           Write(rand.mult());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>\r\n            <b>Div:</b>\r\n        </p>\r\n        <p> ");
#nullable restore
#line 42 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
       Write(rand.f);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 42 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                 Write(rand.s);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = ");
#nullable restore
#line 42 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
                           Write(rand.div());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n        <footer>\r\n            <hr />\r\n            <p>© ");
#nullable restore
#line 46 "C:\Users\Ryaba\Desktop\учеба 3 курс\web\WebSS\WebSS\Views\Home\PassUsingViewData.cshtml"
            Write(DateTime.Now.ToString("yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - WebSS</p>\r\n        </footer>\r\n");
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
            WriteLiteral("\r\n</html>");
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
