#pragma checksum "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7303e66e6b49da787e498016fa9f043272a00c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
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
#line 1 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7303e66e6b49da787e498016fa9f043272a00c9c", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b41dfc849bffe7be2b1ee1cb8ed71ed563af51", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< WebApplication1.Models.Drink>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h2> ");
#nullable restore
#line 14 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
Write(ViewBag.Current);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n \r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 18 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
 foreach (var item in Model

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
                                     )
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4\">\r\n<div class=\"card \" style=\"width: 18rem; padding: 15px; margin-bottom: 30px;\" >\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7303e66e6b49da787e498016fa9f043272a00c9c6314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 480, "~/Images/", 480, 9, true);
#nullable restore
#line 23 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
AddHtmlAttributeValue("", 489, item.ImgThumbilUrl, 489, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
#nullable restore
#line 25 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <span class=\"text-right\" >( ");
#nullable restore
#line 25 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
                                                              Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ) </span> </h5>\r\n    <p class=\"card-text\">");
#nullable restore
#line 26 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
                    Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7303e66e6b49da787e498016fa9f043272a00c9c9002", async() => {
                WriteLiteral("\r\n        Add To Cart\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-drinkId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
                                                                           WriteLiteral(item.DrinkId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drinkId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-drinkId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["drinkId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n  </div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 35 "E:\BackEnd___Organize it\Third\Org Project\DrinkShop\WebApplication1\WebApplication1\Views\Drink\List.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< WebApplication1.Models.Drink>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
