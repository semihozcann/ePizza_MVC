#pragma checksum "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e215b2ed62815db6d00241848e7ede8e32a68fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.UI.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.Entities.Dtos.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.Entities.Dtos.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\_ViewImports.cshtml"
using ePizza.Entities.Dtos.ProductTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
using ePizza.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e215b2ed62815db6d00241848e7ede8e32a68fed", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16be93f4ab04ebfddf13e503c021fca469e2fb61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Payment_Index : ePizza.UI.Helpers.BaseViewPage<PaymentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Payment | ePizza";
    Address address = TempData.Peek<Address>("Address");

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\n");
#nullable restore
#line 8 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\n            <div class=\"col-lg-8\">\n                <div class=\"card mb-3\">\n                    <div class=\"col-sm-12\">\n                        <h5 class=\"mt-3\">Sipariş Detayı <span class=\"float-right\"> Ürünler (s): ");
#nullable restore
#line 14 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                                                                           Write(Model.Cart.Products.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\n                    </div>\n                    <hr />\n                    <div class=\"card-body pt-0 pb-0\">\n");
#nullable restore
#line 18 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                         foreach (var item in Model.Cart.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-md-5 col-lg-3 col-xl-3"">
                                    <div class=""rounded mb-3 mb-md-0"">
                                        <img class=""rounded w-100""");
            BeginWriteAttribute("src", "\n                                     src=\"", 946, "\"", 1003, 1);
#nullable restore
#line 24 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 989, item.ImageUrl, 989, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Sample"">
                                    </div>
                                </div>
                                <div class=""col-md-7 col-lg-9 col-xl-9"">
                                    <div class=""d-flex justify-content-between"">
                                        <div>
                                            <h5>");
#nullable restore
#line 30 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                            <p class=\"mb-2 text-muted small\">Size: Regular</p>\n                                            <p class=\"mb-2 text-muted small\">\n                                                Unit Price: ");
#nullable restore
#line 33 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                                       Write(item.UnitPrice.ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div>
                                            <div class=""def-number-input number-input safari_only mb-0 w-100"">
                                                <div class=""input-group mb-3"">
                                                    <input class=""form-control sm-control"" size=""2"" min=""0"" name=""quantity""");
            BeginWriteAttribute("value", " value=\"", 2086, "\"", 2108, 1);
#nullable restore
#line 39 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2094, item.Quantity, 2094, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                                                </div>
                                            </div>
                                            <span id=""spanTotal"" class=""form-text text-muted text-center"">
                                                Total : ");
#nullable restore
#line 43 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                                    Write((item.UnitPrice * @item.Quantity).ToString("##.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </span>\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n");
#nullable restore
#line 49 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                             if (Model.Cart.Products.IndexOf(item) < Model.Cart.Products.Count - 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr class=\"mb-4\">\n");
#nullable restore
#line 52 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""col-sm-12"">
                        <h5 class=""mt-2"">Sipariş  Adresi</h5>
                    </div>
                    <hr />
                    <div class=""card-body pb-0"">
                        <dl class=""row"">
                            <dt class=""col-sm-2"">

                                Sokak
                            </dt>
                            <dd class=""col-sm-4"">
                                ");
#nullable restore
#line 66 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                Semt\n                            </dt>\n                            <dd class=\"col-sm-4\">\n                                ");
#nullable restore
#line 72 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(address.Locality);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                Posta Kodu\n                            </dt>\n                            <dd class=\"col-sm-4\">\n                                ");
#nullable restore
#line 78 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(address.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                İletişim No.\n                            </dt>\n                            <dd class=\"col-sm-4\">\n                                ");
#nullable restore
#line 84 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(address.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                        </dl>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card mb-3"">
                    <div class=""col-sm-12"">
                        <h5 class=""mt-3"">Sipariş Özeti</h5>
                    </div>
                    <hr />
                    <div class=""card-body pt-0"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center border-0 px-0"">

                                Fiyat
                                <span>");
#nullable restore
#line 101 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                 Write(Model.Cart.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</span>\n                            </li>\n                            <li class=\"list-group-item d-flex justify-content-between align-items-center border-0 px-0\">\n\n                                Vergi (5%)\n                                <span>+");
#nullable restore
#line 106 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                  Write(Model.Cart.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ₺</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center  px-0 mb-3"">
                                <strong>Total Fiyat</strong>
                                <span><strong> ");
#nullable restore
#line 110 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                          Write(Model.Cart.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</strong></span>\n                            </li>\n                        </ul>\n");
#nullable restore
#line 113 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                         if (CurrentUser != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button id=\"rzp-button\" hidden>Pay</button>\n");
#nullable restore
#line 116 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                             using (Html.BeginForm("Status", "Payment", FormMethod.Post, new { id = "PaymentForm", name = "PaymentForm" }))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("Receipt", Model.Receipt));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                                                      
                                ;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("Currency", "INR"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                                                               
                                ;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_signature"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_paymentid"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                           Write(Html.Hidden("rzp_orderid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"submit\" id=\"rzp-paymentresponse\" hidden style=\"display: none;\">Submit</button>\n");
#nullable restore
#line 127 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-primary btn-block\" onclick=\"submitToPayment()\">Şimdi Öde</a>\n");
#nullable restore
#line 129 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 134 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n<script src=\"https://checkout.razorpay.com/v1/checkout.js\"></script>\n<script>\n    var options = {\n        \"key\": \"");
#nullable restore
#line 139 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
           Write(Model.RazorPayKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        \"amount\": \"");
#nullable restore
#line 140 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
               Write(Model.GrandTotal * 100);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        \"currency\": \"");
#nullable restore
#line 141 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                Write(Model.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        \"name\": \"");
#nullable restore
#line 142 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        \"description\": \"");
#nullable restore
#line 143 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        \"image\": \"https://www.dotnettricks.com/images/d-icon.png\",\n        //\"image\": \"/images/icon.png\",\n        \"order_id\": \"");
#nullable restore
#line 146 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        ""handler"": function (response) {
            document.getElementById('rzp_paymentid').value = response.razorpay_payment_id;
            document.getElementById('rzp_orderid').value = response.razorpay_order_id;
            $(""#rzp_signature"").val(response.razorpay_signature);
            $('#PaymentForm').submit();
        },
        ""prefill"": {
            ""name"": """);
#nullable restore
#line 154 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                Write(CurrentUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n            \"email\": \"");
#nullable restore
#line 155 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                 Write(CurrentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n            \"contact\": \"");
#nullable restore
#line 156 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Views\Payment\Index.cshtml"
                   Write(CurrentUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        },
        ""notes"": {
            ""address"": ""NA""
        },
        ""theme"": {
            ""color"": ""#4285F4""
        }
    };
    var rzp = new Razorpay(options);
    window.onload = function () {
        document.getElementById('rzp-button').click();
    };
    document.getElementById('rzp-button').onclick = function (e) {
        rzp.open();
        e.preventDefault();
    };
    function submitToPayment() {
        rzp.open();
        e.preventDefault();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
