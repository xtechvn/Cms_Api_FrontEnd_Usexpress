#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c5c022adb0b3ea3a0cb727b0660934867e9146c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_product_blog_product_hunter_deals), @"mvc.1.0.view", @"/Views/Shared/Components/product/blog/product_hunter_deals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/product/blog/product_hunter_deals.cshtml", typeof(AspNetCore.Views_Shared_Components_product_blog_product_hunter_deals))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c5c022adb0b3ea3a0cb727b0660934867e9146c", @"/Views/Shared/Components/product/blog/product_hunter_deals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_product_blog_product_hunter_deals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WEB.UI.ViewModels.GroupProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
 if (Model != null)
{


#line default
#line hidden
            BeginContext(80, 167, true);
            WriteLiteral("    <div class=\"box-san-hang-hieu mb25\">\r\n        <h2 class=\"title_category\">SĂN DEAL HÀNG HIỆU</h2>\r\n        <div class=\"list\">\r\n            <div class=\"flex gird\">\r\n");
            EndContext();
#line 9 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(312, 35, true);
            WriteLiteral("                    <a class=\"item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 347, "\"", 364, 1);
#line 11 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
WriteAttributeValue("", 354, item.link, 354, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 90, true);
            WriteLiteral(">\r\n                        <div class=\"thumb thumb_5x4\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 455, "\"", 517, 1);
#line 13 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
WriteAttributeValue("", 461, Html.Raw("https://image.usexpress.vn"+item.image_thumb), 461, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 518, "\"", 534, 1);
#line 13 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
WriteAttributeValue("", 524, item.name, 524, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(535, 115, true);
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"conten\">\r\n                            <h4>");
            EndContext();
            BeginContext(651, 9, false);
#line 16 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
                           Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(660, 38, true);
            WriteLiteral("</h4>\r\n                            <p>");
            EndContext();
            BeginContext(699, 19, false);
#line 17 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
                          Write(Html.Raw(item.desc));

#line default
#line hidden
            EndContext();
            BeginContext(718, 64, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </a>\r\n");
            EndContext();
#line 20 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
                }

#line default
#line hidden
            BeginContext(801, 174, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"center mt20 mb10\">\r\n                <a href=\"/\" class=\"load-more\">Xem thêm</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 28 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(987, 16, true);
            WriteLiteral("    <p>...</p>\r\n");
            EndContext();
#line 32 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_hunter_deals.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WEB.UI.ViewModels.GroupProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
