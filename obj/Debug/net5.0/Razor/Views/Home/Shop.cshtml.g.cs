#pragma checksum "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06a4c55ac7ef482b7d648e14194668cc52d89e82b21c51d0e841daf52e6bf883"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06a4c55ac7ef482b7d648e14194668cc52d89e82b21c51d0e841daf52e6bf883", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c4b69f827cab216a62a24d0ea4103f5ee0124951f90f47bca76a21082b0469b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<section class=""shop"">

    <div class=""top"" style=""margin-top:100px;"">
        <section class=""Overview"">
            <div class=""top"">
                <h1>Product Overview</h1>
            </div>
            <div class=""center"">
                <ul class=""left"">
                    <a href=""/Home/Shop"">
                    <li");
            BeginWriteAttribute("class", " class=\"", 368, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        All Products\r\n                        <hr>\r\n                    </li>\r\n                    </a>\r\n");
#nullable restore
#line 20 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                     foreach (var item in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 647, 2);
            WriteAttributeValue("", 620, "/Home/Shop/", 620, 11, true);
            WriteAttributeValue("", 631, 
#nullable restore
#line 22 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                             item.CategoryId

#line default
#line hidden
#nullable disable
            , 631, 16, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 678, "\"", 704, 1);
            WriteAttributeValue("", 686, 
#nullable restore
#line 23 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                    item.CategoryName

#line default
#line hidden
#nullable disable
            , 686, 18, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 23 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                                        item.CategoryName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("<hr></li>\r\n                        </a>\r\n");
#nullable restore
#line 25 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </ul>\r\n");
            WriteLiteral(@"            </div>
            <div class=""filter-search"">
                <div id=""SearchMenu"" class=""search "">
                    <div class=""searchbar"">
                        <i class=""fa-solid fa-magnifying-glass""></i>
                        <input type=""text"" placeholder=""Search...""");
            BeginWriteAttribute("class", " class=\"", 1751, "\"", 1759, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n\r\n    </div>\r\n    <section class=\"products\">\r\n\r\n");
#nullable restore
#line 206 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"product\"");
            BeginWriteAttribute("cat", " cat=\"", 8288, "\"", 8328, 1);
            WriteAttributeValue("", 8294, 
#nullable restore
#line 208 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                       item.ProductCategory.CategoryName

#line default
#line hidden
#nullable disable
            , 8294, 34, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"productIn\">\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 8442, "\"", 8490, 2);
            WriteAttributeValue("", 8448, "/images/", 8448, 8, true);
            WriteAttributeValue("", 8456, 
#nullable restore
#line 211 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                           item.Photos.ToList()[0].PhotoName

#line default
#line hidden
#nullable disable
            , 8456, 34, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8491, "\"", 8497, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8527, "\"", 8565, 2);
            WriteAttributeValue("", 8534, "/Home/QuickView/", 8534, 16, true);
            WriteAttributeValue("", 8550, 
#nullable restore
#line 212 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                                  item.ProductId

#line default
#line hidden
#nullable disable
            , 8550, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"hiddendiv\">Quick View</a>\r\n                    </div>\r\n                    <div class=\"text\">\r\n                        <div class=\"div\">\r\n                            <p>");
            Write(
#nullable restore
#line 216 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                item.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 217 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 8892, "\"", 8933, 2);
            WriteAttributeValue("", 8899, "/Home/AddFavorites/", 8899, 19, true);
            WriteAttributeValue("", 8918, 
#nullable restore
#line 219 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                                         item.ProductId

#line default
#line hidden
#nullable disable
            , 8918, 15, false);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-regular fa-heart heart\"></i></a>\r\n");
#nullable restore
#line 220 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </div>\r\n                        <span");
            BeginWriteAttribute("class", " class=\"", 9078, "\"", 9086, 0);
            EndWriteAttribute();
            WriteLiteral(">$ ");
            Write(
#nullable restore
#line 222 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                          item.ProductPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                        <span class=\"branchname\">");
            Write(
#nullable restore
#line 223 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"
                                                  item.ProductBranch.BranchName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 227 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\Shop.cshtml"

        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n    </section>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
