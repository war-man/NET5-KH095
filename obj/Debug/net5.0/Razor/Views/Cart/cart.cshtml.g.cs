#pragma checksum "E:\project\c#\KH095\Views\Cart\cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968c3966ce2028b8546855a169a6bef34147e8c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_cart), @"mvc.1.0.view", @"/Views/Cart/cart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\project\c#\KH095\Views\_ViewImports.cshtml"
using KH095.Extension;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968c3966ce2028b8546855a169a6bef34147e8c6", @"/Views/Cart/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3777134f5590a2b8b0658cd514a81aa8a3c922e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/style-product-detail.css\" />\r\n    <link rel=\"stylesheet\" href=\"/_responsive.css\" />\r\n    <style>\r\n        td, th {\r\n            padding: 10px;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 16 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
 if (Model.Count > 0) {
  decimal total = 0;
  int stt = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("      <table class=\"table\">\r\n    <tr>\r\n      <th>#</th>\r\n      <th>Sản phẩm</th>\r\n      <th>Giá</th>\r\n      <th>Số lượng</th>\r\n      <th>Thành tiền</th>\r\n      <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 29 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
     foreach (var cartitem in Model)
    {
        var thanhtien = cartitem.quantity * cartitem.product.Price;
        total = total + (decimal)thanhtien;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n           <td>");
#nullable restore
#line 35 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
           Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 36 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
          Write(cartitem.product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 37 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
           Write(cartitem.product.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "968c3966ce2028b8546855a169a6bef34147e8c65676", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
AddHtmlAttributeValue("", 892, $"quantity-{cartitem.product.Id}", 892, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 39 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
           Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>\r\n              <button class=\"btn btn-success updatecartitem\" \r\n                    data-productid=\"");
#nullable restore
#line 42 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
                               Write(cartitem.product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Cập nhật</button>\r\n              <a");
            BeginWriteAttribute("href", " href=\"", 1160, "\"", 1199, 2);
            WriteAttributeValue("", 1167, "/removecart/", 1167, 12, true);
#nullable restore
#line 43 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
WriteAttributeValue("", 1179, cartitem.product.Id, 1179, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                class=\"btn btn-danger\">Xóa</a>\r\n           </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td colspan=\"4\" class=\"text-right\">Tổng tiền</td>\r\n          <td>");
#nullable restore
#line 50 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
          Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td></td>\r\n      </tr>\r\n  </table>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "968c3966ce2028b8546855a169a6bef34147e8c69237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $("".updatecartitem"").click(function (event) {
                    event.preventDefault();
                    var productid = $(this).attr(""data-productid"");
                    var quantity = $(""#quantity-"" + productid).val();
                    var data = {
                            productid: productid,
                            quantity: quantity
                        };
                    console.log(data);
                    fetch(""");
#nullable restore
#line 68 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
                      Write(Url.RouteUrl("updatecart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",{
                          method: 'POST', // or 'PUT'
                        headers: {
                            'Content-Type': 'application/json',
                        },
                        body: JSON.stringify(data)
                    })
                    .then(data => {
                         window.location.href = """);
#nullable restore
#line 76 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
                                            Write(Url.RouteUrl("cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                    });\r\n                });\r\n            });\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 81 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
     
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p \r\n    class=\"alert alert-danger\"\r\n    style=\"text-align: center;\r\n    padding: 25px;\r\n    font-size: 20px;\r\n    color: red;\"\r\n    >Giỏ hàng trống\r\n    </p>\r\n");
#nullable restore
#line 91 "E:\project\c#\KH095\Views\Cart\cart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
