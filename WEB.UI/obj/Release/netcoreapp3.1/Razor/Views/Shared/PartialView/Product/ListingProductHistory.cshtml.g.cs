#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea5bf99dfa46b4b8d12faed733f19f18bbaeef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialView_Product_ListingProductHistory), @"mvc.1.0.view", @"/Views/Shared/PartialView/Product/ListingProductHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialView/Product/ListingProductHistory.cshtml", typeof(AspNetCore.Views_Shared_PartialView_Product_ListingProductHistory))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\_ViewImports.cshtml"
using WEB.UI;

#line default
#line hidden
#line 2 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\_ViewImports.cshtml"
using WEB.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea5bf99dfa46b4b8d12faed733f19f18bbaeef9", @"/Views/Shared/PartialView/Product/ListingProductHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialView_Product_ListingProductHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/graphics/my.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("amz"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
  
    bool is_waiting = this.ViewData["is_waiting"] == null ? false : true;

#line default
#line hidden
            BeginContext(133, 128, true);
            WriteLiteral("<div class=\"sp_daxem bg_warp mb20\">\r\n    <h2 class=\"title-label\">Sản phẩm bạn đã xem</h2>\r\n    <div class=\"list-product flex\">\r\n");
            EndContext();
#line 8 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
         if (is_waiting)
        {

#line default
#line hidden
            BeginContext(298, 88, true);
            WriteLiteral("            <div class=\"product-item col-5\">\r\n                <a class=\"ava placeholder\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 386, "\"", 393, 0);
            EndWriteAttribute();
            BeginContext(394, 451, true);
            WriteLiteral(@">
                </a>
                <div class=""content"">
                    <div class=""ct_star placeholder"" style=""height: 15px;"">
                    </div>
                    <h3 class=""title placeholder"" style=""height: 40px;""></h3>
                    <div class=""flex placeholder"" style=""height:15px""></div>
                    <a class=""brand_label placeholder"" style=""height:15px""></a>
                </div>
            </div>
");
            EndContext();
#line 21 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
             for (int i = 0; i < 4; i++)
            {

#line default
#line hidden
            BeginContext(902, 96, true);
            WriteLiteral("                <div class=\"product-item col-5\">\r\n                    <a class=\"ava placeholder\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 998, "\"", 1005, 0);
            EndWriteAttribute();
            BeginContext(1006, 487, true);
            WriteLiteral(@">
                    </a>
                    <div class=""content"">
                        <div class=""ct_star placeholder"" style=""height: 15px;"">
                        </div>
                        <h3 class=""title placeholder"" style=""height: 40px;""></h3>
                        <div class=""flex placeholder"" style=""height:15px""></div>
                        <a class=""brand_label placeholder"" style=""height:15px""></a>
                    </div>
                </div>
");
            EndContext();
#line 34 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
            }

#line default
#line hidden
#line 34 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
             
        }
        else
        {
            

#line default
#line hidden
#line 38 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
             foreach (var item in Model)
            {                
                var rd = new Random();

#line default
#line hidden
            BeginContext(1657, 52, true);
            WriteLiteral("                <div class=\"product-item col-5\">\r\n\r\n");
            EndContext();
            BeginContext(1763, 34, true);
            WriteLiteral("                    <a class=\"ava\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1797, "\"", 1822, 1);
#line 44 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
WriteAttributeValue("", 1804, item.link_product, 1804, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1823, 31, true);
            WriteLiteral(">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1854, "\"", 1879, 1);
#line 45 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
WriteAttributeValue("", 1860, item.image_thumb, 1860, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1880, 380, true);
            WriteLiteral(@" />
                        <span class=""like active"">
                            <svg class=""icon-us"">
                                <use xlink:href=""/images/icons/icon.svg#heart""></use>
                            </svg>
                        </span>
                    </a>
                    <div class=""content"">
                        <div class=""ct_star"">
");
            EndContext();
#line 54 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
                               await Html.RenderPartialAsync("PartialView/Product/Element/star", null, new ViewDataDictionary(this.ViewData) { { "star", item.star } });

#line default
#line hidden
            BeginContext(2431, 46, true);
            WriteLiteral("                            <span class=\"buy\">");
            EndContext();
            BeginContext(2479, 62, false);
#line 55 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
                                          Write(item.reviews_count >0 ? item.reviews_count : rd.Next(600,2000));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 176, true);
            WriteLiteral(" lượt đánh giá</span>\r\n                        </div>\r\n                        <h3 class=\"title\">\r\n                            <img src=\"/images/icons/prime.png\" title=\"amz\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2718, "\"", 2743, 1);
#line 58 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
WriteAttributeValue("", 2725, item.link_product, 2725, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2744, "\"", 2770, 1);
#line 58 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
WriteAttributeValue("", 2752, item.product_name, 2752, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2771, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(2807, 17, false);
#line 59 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
                           Write(item.product_name);

#line default
#line hidden
            EndContext();
            BeginContext(2824, 271, true);
            WriteLiteral(@"
                            </a>
                        </h3>
                        <div class=""flex"">
                            <div class=""col-2"">
                                <span>Giá về tay</span>
                                <strong class=""price"">");
            EndContext();
            BeginContext(3096, 42, false);
#line 65 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
                                                 Write(Math.Round(item.amount_vnd).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 127, true);
            WriteLiteral(" đ</strong>\r\n                            </div>\r\n                        </div>\r\n                        <a class=\"brand_label\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3265, "\"", 3292, 1);
#line 68 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
WriteAttributeValue("", 3272, item.keywork_search, 3272, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3293, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(3324, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5ea5bf99dfa46b4b8d12faed733f19f18bbaeef912555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3372, 17, true);
            WriteLiteral("Sản phẩm bán tại ");
            EndContext();
            BeginContext(3390, 15, false);
#line 69 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
                                                                                        Write(item.label_name);

#line default
#line hidden
            EndContext();
            BeginContext(3405, 58, true);
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 72 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
            }

#line default
#line hidden
#line 72 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Product\ListingProductHistory.cshtml"
             
        }

#line default
#line hidden
            BeginContext(3489, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
