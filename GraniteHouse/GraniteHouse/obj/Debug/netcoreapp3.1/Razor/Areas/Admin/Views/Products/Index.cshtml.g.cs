#pragma checksum "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d629572514b7f3063a39a2b4366b2e7a0b4e25e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
#line 1 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\_ViewImports.cshtml"
using GraniteHouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d629572514b7f3063a39a2b4366b2e7a0b4e25e", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add87ae52faa7df67fbebca5d3c39a845d0e03fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GraniteHouse.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var AvailableCount = Model.Count(x => x.Available==true);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Product List</h2>\r\n        ");
#nullable restore
#line 12 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
   Write(AvailableCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d629572514b7f3063a39a2b4366b2e7a0b4e25e5132", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
#nullable restore
#line 23 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.ProductTypes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.SpecialTags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.ShadeColors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th class=\"text-center\">Actions</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 44 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
             if (item.Available == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n\r\n");
#nullable restore
#line 59 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                         if (item.Available == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: green\">Yes</span>\r\n");
#nullable restore
#line 62 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: red\">No</span>\r\n");
#nullable restore
#line 66 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ProductTypes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SpecialTags.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ShadeColors.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d629572514b7f3063a39a2b4366b2e7a0b4e25e12502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 84 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\" color: red\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n\r\n");
#nullable restore
#line 101 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                         if (item.Available == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: green\">Yes</span>\r\n");
#nullable restore
#line 104 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"color: red\">No</span>\r\n");
#nullable restore
#line 108 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ProductTypes.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 116 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.SpecialTags.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 120 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ShadeColors.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d629572514b7f3063a39a2b4366b2e7a0b4e25e17694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 126 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 129 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "G:\ASP.NET\Practice\GraniteHouse-ASP.NET-Core-MVC-\GraniteHouse\GraniteHouse\Areas\Admin\Views\Products\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GraniteHouse.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
