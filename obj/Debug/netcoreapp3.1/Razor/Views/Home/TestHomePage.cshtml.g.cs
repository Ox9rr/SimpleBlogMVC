#pragma checksum "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63a75b400bd1c5247e6af5c78e4a27383754d284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestHomePage), @"mvc.1.0.view", @"/Views/Home/TestHomePage.cshtml")]
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
#line 1 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\_ViewImports.cshtml"
using SimpleBlogMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\_ViewImports.cshtml"
using SimpleBlogMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a75b400bd1c5247e6af5c78e4a27383754d284", @"/Views/Home/TestHomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ef3266872024f5c0945984db79fb28368f60d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestHomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimpleBlogMVC.Models.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container px-4 px-lg-5\">\r\n    <div class=\"row gx-4 gx-lg-5 justify-content-center\">\r\n        <div class=\"col-md-10 col-lg-8 col-xl-7\">\r\n            <!-- Post preview-->\r\n");
#nullable restore
#line 13 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml"
             foreach (var item in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-preview\">\r\n                    <a href=\"post.html\">\r\n                        <h2 class=\"post-title\">");
#nullable restore
#line 17 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h3 class=\"post-subtitle\">");
#nullable restore
#line 18 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </a>\r\n                    <p class=\"post-meta\">\r\n                        Posted by\r\n                        <a href=\"#!\">Redactione</a>\r\n                        ");
#nullable restore
#line 23 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml"
                   Write(item.DateCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\619mi\Desktop\SimpleBlogMVC\SimpleBlogMVC\Views\Home\TestHomePage.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimpleBlogMVC.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591