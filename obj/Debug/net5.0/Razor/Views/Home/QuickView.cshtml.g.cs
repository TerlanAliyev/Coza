#pragma checksum "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3c1041db083025569dfbf6656db2e7072449630af63eea70fb0b3fed04a1a5ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuickView), @"mvc.1.0.view", @"/Views/Home/QuickView.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Terlan\source\repos\Coza\Coza\Views\_ViewImports.cshtml"
using Coza

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Terlan\source\repos\Coza\Coza\Views\_ViewImports.cshtml"
using Coza.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3c1041db083025569dfbf6656db2e7072449630af63eea70fb0b3fed04a1a5ed", @"/Views/Home/QuickView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c4b69f827cab216a62a24d0ea4103f5ee0124951f90f47bca76a21082b0469b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_QuickView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"QuickView\">\r\n    <div class=\"container\">\r\n        <div class=\"main\">\r\n            <div class=\"left-side\">\r\n                <div class=\"littleimages\">\r\n");
#nullable restore
#line 8 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                     foreach (var item in Model.Photos)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <div class=\"littleimage\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 348, "\"", 377, 2);
            WriteAttributeValue("", 354, "/images/", 354, 8, true);
            WriteAttributeValue("", 362, 
#nullable restore
#line 11 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                                               item.PhotoName

#line default
#line hidden
#nullable disable
            , 362, 15, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 378, "\"", 384, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 13 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </div>\r\n                <div class=\"mainimage\">\r\n                    <i onclick=\"left()\" class=\"fa-solid fa-chevron-left\"></i>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 611, "\"", 660, 2);
            WriteAttributeValue("", 617, "/images/", 617, 8, true);
            WriteAttributeValue("", 625, 
#nullable restore
#line 17 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                                       Model.Photos.ToList()[0].PhotoName

#line default
#line hidden
#nullable disable
            , 625, 35, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 661, "\"", 667, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <i onclick=\"right()\" class=\"fa-solid fa-chevron-right\"></i>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"right-side\">\r\n                <div class=\"top\">\r\n                    <h1>");
            Write(
#nullable restore
#line 25 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                         Model.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n                    <p>\r\n                        ");
            Write(
#nullable restore
#line 27 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                         Model.ProductDescreption

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                    </p>\r\n                    <span>$</span><span>");
            Write(
#nullable restore
#line 29 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                                         Model.ProductPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n\r\n                </div>\r\n                <div class=\"bottom\">\r\n");
            WriteLiteral("                        <div class=\"addtocart\">\r\n\r\n");
#nullable restore
#line 70 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                              if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <div class=\"addbtn\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3305, "\"", 3350, 2);
            WriteAttributeValue("", 3312, "/Home/AddShoppingCart/", 3312, 22, true);
            WriteAttributeValue("", 3334, 
#nullable restore
#line 73 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                                                                Model.ProductId

#line default
#line hidden
#nullable disable
            , 3334, 16, false);
            EndWriteAttribute();
            WriteLiteral(">ADD TO CART</a>\r\n                            </div>\r\n");
#nullable restore
#line 75 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\QuickView.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<script src=\"/js/QuickView.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
