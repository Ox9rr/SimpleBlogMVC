#pragma checksum "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\Home\TestGetPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c63d44e2f3b1bbeda33ba6723a537ed6a5ae5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestGetPost), @"mvc.1.0.view", @"/Views/Home/TestGetPost.cshtml")]
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
#line 1 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\_ViewImports.cshtml"
using SimpleBlogMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\_ViewImports.cshtml"
using SimpleBlogMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c63d44e2f3b1bbeda33ba6723a537ed6a5ae5b", @"/Views/Home/TestGetPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ef3266872024f5c0945984db79fb28368f60d5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_TestGetPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimpleBlogMVC.Models.Article>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\Home\TestGetPost.cshtml"
   foreach (var item in Model)
    {
        ViewData["Title"] = item.Title;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Post Content-->\r\n<article class=\"mb-4\">\r\n    <div class=\"container px-4 px-lg-5\">\r\n        <div class=\"row gx-4 gx-lg-5 justify-content-center\">\r\n            <div class=\"col-md-10 col-lg-8 col-xl-7\">\r\n");
#nullable restore
#line 18 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\Home\TestGetPost.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\Home\TestGetPost.cshtml"
               Write(Html.Raw(@item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <p>
                        Placeholder text by
                        <a href=""http://spaceipsum.com/"">Space Ipsum</a>
                        &middot; Images by
                        <a href=""https://www.flickr.com/photos/nasacommons/"">NASA on The Commons</a>
                    </p>
");
#nullable restore
#line 27 "C:\Users\Misha\Source\Repos\SimpleBlogMVC\Views\Home\TestGetPost.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</article>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimpleBlogMVC.Models.Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
