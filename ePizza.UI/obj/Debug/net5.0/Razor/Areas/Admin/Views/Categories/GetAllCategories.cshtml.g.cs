#pragma checksum "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2260748bf495b32a6623e2dfa0d4915b28b74a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_GetAllCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/GetAllCategories.cshtml")]
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
#line 1 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizza.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizza.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizza.UI.Models.ProductTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizza.UI.Models.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\_ViewImports.cshtml"
using ePizza.UI.Models.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2260748bf495b32a6623e2dfa0d4915b28b74a10", @"/Areas/Admin/Views/Categories/GetAllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d226e824c87e070a54361a136adbb7d6607a12e8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Categories_GetAllCategories : ePizza.UI.Helpers.BaseViewPage<CategoryListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
  
    ViewData["Title"] = "GetAllCategories";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>GetAllCategories</h1>\n\n<div class=\"container\">\n\n    <div id=\"addButtonTable\">\n        <table>\n            <tr>\n                <td>Kategori eklemek için ekle butonuna tıklayınız</td>\n                <td>:</td>\n                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2260748bf495b32a6623e2dfa0d4915b28b74a105805", async() => {
                WriteLiteral("Kategori Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n            </tr>\n        </table>\n    </div>\n\n");
#nullable restore
#line 22 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
     if (Model !=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
            <table class=""table"" id=""ListTable"">
                <thead>
                    <tr>
                        <td>Id</td>
                        <td>Kategori Adı</td>
                        <td>Açıklaması</td>
                        <td>Güncelle</td>
                        <td>Sil</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 36 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
                     foreach (var category in Model.CategoryListDto.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 39 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 41 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
                           Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1270, "\"", 1314, 2);
            WriteAttributeValue("", 1277, "/Admin/Categories/Update/", 1277, 25, true);
#nullable restore
#line 42 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 1302, category.Id, 1302, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"ListTableButton\">Güncelle</a></td>\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1389, "\"", 1433, 2);
            WriteAttributeValue("", 1396, "/Admin/Categories/Delete/", 1396, 25, true);
#nullable restore
#line 43 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
WriteAttributeValue("", 1421, category.Id, 1421, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"ListTableButton\">Sil</a></td>\n                        </tr>\n");
#nullable restore
#line 45 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n\n        </div>\n");
#nullable restore
#line 50 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Hiç Veri Bulunamadı</p>\n");
#nullable restore
#line 54 "C:\Users\semih\Desktop\ePizzaLast-main\ePizzaLast-main\ePizza.UI\Areas\Admin\Views\Categories\GetAllCategories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591