#pragma checksum "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393c17aee2736a3d6b8c4aebed5257b67df887ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
#line 1 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\_ViewImports.cshtml"
using FiorellaBackToFrontProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\_ViewImports.cshtml"
using FiorellaBackToFrontProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393c17aee2736a3d6b8c4aebed5257b67df887ac", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9e4e7f8ca53ac9266aea4287f5b9772468b5a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 50px; width: 50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <tr>\r\n        <td>");
#nullable restore
#line 5 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 6 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "393c17aee2736a3d6b8c4aebed5257b67df887ac4535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 168, "~/img/", 168, 6, true);
#nullable restore
#line 8 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 174, item.Image, 174, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <a class=\"btn btn-primary mr-1\" id=\"decrease-btn\" data-id=\"");
#nullable restore
#line 11 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
            WriteLiteral(">-</a>\r\n            ");
#nullable restore
#line 12 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            <a class=\"btn btn-primary ml-1\" id=\"increase-btn\" data-id=\"");
#nullable restore
#line 13 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
            WriteLiteral(">+</a>\r\n        </td>\r\n        <td>$");
#nullable restore
#line 15 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
         Write(item.Price*item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a class=\"btn btn-danger\" id=\"cart-delete-btn\" data-id = \"");
#nullable restore
#line 16 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
            WriteLiteral(">delete</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\CLearningCC\FiorellaBackToFrontProject\FiorellaBackToFrontProject\Views\Shared\_BasketPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
