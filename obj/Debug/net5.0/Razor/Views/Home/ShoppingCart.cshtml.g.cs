#pragma checksum "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc1901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShoppingCart), @"mvc.1.0.view", @"/Views/Home/ShoppingCart.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
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

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
 using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc1901", @"/Views/Home/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1c4b69f827cab216a62a24d0ea4103f5ee0124951f90f47bca76a21082b0469b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Basket>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "option1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "option2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""shoppingCart"">
 
    <div class=""Shoppingcart"">
        <div class=""prodinfo"">
           
            <div class=""infoline"">
                <h1>Product</h1>
                <h1 style=""padding-left:20px;"">Price</h1>
                <h1 class=""Quantity"" style=""padding-left:20px;"">Quantity</h1>
                <h1 class=""TopTotal"">Total</h1>
            </div>
            <hr>
            <h1 id=""empty-message"" style=""width:20%;margin:auto;padding:30px 0px"">There is empty</h1>

");
#nullable restore
#line 19 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"prodline\">\r\n                    <div class=\"prodimg\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 726, "\"", 788, 2);
            WriteAttributeValue("", 732, "/images/", 732, 8, true);
            WriteAttributeValue("", 740, 
#nullable restore
#line 23 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
                                           item.BasketProduct.Photos.ToList()[0].PhotoName

#line default
#line hidden
#nullable disable
            , 740, 48, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 789, "\"", 795, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"prodname\">");
            Write(
#nullable restore
#line 24 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
                                               item.BasketProduct.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 910, "\"", 956, 2);
            WriteAttributeValue("", 917, "/Home/DeleteShoppingCart/", 917, 25, true);
            WriteAttributeValue("", 942, 
#nullable restore
#line 25 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
                                                           item.BasketId

#line default
#line hidden
#nullable disable
            , 942, 14, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fa-solid fa-circle-minus\"></i>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"prodprice\">\r\n                        <h1>$ <span>");
            Write(
#nullable restore
#line 30 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
                                     item.BasketProduct.ProductPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span></h1>
                    </div>
                    <div class=""prodquantity"">
                        <div class=""counter"">
                            <div class=""minus"">
                                <i class=""fa-solid fa-minus""></i>
                            </div>
                            <div class=""number"">1</div>
                            <div class=""plus"">
                                <i class=""fa-solid fa-plus""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""prodtotal"">
                        <h1>$ <span>");
            Write(
#nullable restore
#line 44 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
                                     item.BasketProduct.ProductPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span></h1>\r\n                    </div>\r\n                </div>\r\n                <hr>\r\n");
#nullable restore
#line 48 "C:\Users\Terlan\source\repos\Coza\Coza\Views\Home\ShoppingCart.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"buttonsfooter\">\r\n                <div class=\"coupon\">\r\n                    <input type=\"text\" placeholder=\"Coupon Code\">\r\n                </div>\r\n                <div class=\"updatecart\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2207, "\"", 2214, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""updetatotals"">
                        APPLY
                    </a>
                </div>

            </div>
        </div>
        <div class=""cartinfo"">
            <div class=""top"">
                <h1>Cart Totals</h1>
                <p>Subtotal: <span>$79.65</span></p>
            </div>
            <div class=""bottom"">
                <div class=""left"">
                    <h1>Shipping:</h1>
                </div>
                <div class=""right"">
                    <p>
                        There are no shipping methods available. Please double check your address, or contact us if
                        you
                        need any help.
                    </p>
                    <div class=""CalculateShipping"">
                        <h2>Calculate Shipping</h2>
                        <select class=""custom-select"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc19019453", async() => {
                WriteLiteral("Select a country");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc190110674", async() => {
                WriteLiteral("Azerbaijan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                        <select class=\"custom-select\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc190111987", async() => {
                WriteLiteral("Select a city");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc190113206", async() => {
                WriteLiteral("Baku");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                        <select class=\"custom-select\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc190114513", async() => {
                WriteLiteral("Post code / Zip");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4931c61242475d96fd8513f85f05169fc671e7977e163897708645725adc190115734", async() => {
                WriteLiteral("5500");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3786, "\"", 3793, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""updetatotals"">
                            UPDATE TOTALS
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>



<script>

    document.addEventListener('DOMContentLoaded', () => {
        const prodinfo = document.querySelector("".prodinfo"")

        function checkProducts() {
            const basketDivs = prodinfo.querySelectorAll('.prodline');

            if ( basketDivs.length === 0) {
                let emptyMessage = document.getElementById('empty-message');
                if (!emptyMessage) {
                    emptyMessage = document.createElement('h1');
                    emptyMessage.id = 'empty-message';
                    emptyMessage.textContent = 'There is empty';
                    productsSection.appendChild(emptyMessage);
                }
            } else {
                const emptyMessage = document.getElementById('empty-message');
                if (emptyMessa");
            WriteLiteral("ge) {\r\n                    prodinfo.removeChild(emptyMessage);\r\n\r\n                }\r\n            }\r\n        }\r\n\r\n        checkProducts();\r\n\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Basket>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
