#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c0f9a6518c9a3d1a561cc026a140cc6da0322c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_product_blog_product_top), @"mvc.1.0.view", @"/Views/Shared/Components/product/blog/product_top.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/product/blog/product_top.cshtml", typeof(AspNetCore.Views_Shared_Components_product_blog_product_top))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c0f9a6518c9a3d1a561cc026a140cc6da0322c", @"/Views/Shared/Components/product/blog/product_top.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_product_blog_product_top : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB.UI.ViewModels.ProductTopEntitiesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
  
    bool is_waiting = this.ViewData["is_waiting"] == null ? false : true;


#line default
#line hidden
#line 6 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
 if (is_waiting)
{

#line default
#line hidden
            BeginContext(159, 234, true);
            WriteLiteral("    <div class=\"slide_sale mb25\">\r\n        <div class=\"head-title flex\">\r\n            <h2 class=\"title_category\">Sản phẩm nổi bật</h2>\r\n        </div>\r\n        <div class=\"swiper-container\">\r\n            <div class=\"swiper-wrapper\">\r\n");
            EndContext();
#line 14 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                 for (int i = 0; i < 6; i++)
                {

#line default
#line hidden
            BeginContext(458, 111, true);
            WriteLiteral("                    <div class=\"swiper-slide product-item\">\r\n                        <a class=\"ava placeholder\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 569, "\"", 576, 0);
            EndWriteAttribute();
            BeginContext(577, 523, true);
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
#line 27 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                }

#line default
#line hidden
            BeginContext(1119, 238, true);
            WriteLiteral("            </div>\r\n            <!-- Add Scrollbar -->\r\n            <div class=\"swiper-scrollbar\"></div>\r\n            <div class=\"swiper-button-next\"></div>\r\n            <div class=\"swiper-button-prev\"></div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"

}
else
{
    if (Model != null)
    {

#line default
#line hidden
            BeginContext(1402, 148, true);
            WriteLiteral("        <div class=\"slide_sale mb25\">\r\n            <div class=\"head-title flex\">\r\n                <h2 class=\"title_category\">Sản phẩm nổi bật</h2>\r\n");
            EndContext();
#line 44 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                 if (Model.obj_tab != null)
                {

#line default
#line hidden
            BeginContext(1614, 48, true);
            WriteLiteral("                    <div class=\"tab_category\">\r\n");
            EndContext();
#line 47 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                          
                            int d = 0;
                            foreach (var item in Model.obj_tab)
                            {

#line default
#line hidden
            BeginContext(1826, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1860, "\"", 1923, 2);
            WriteAttributeValue("", 1868, "tab_product_slide_top", 1868, 21, true);
#line 51 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
WriteAttributeValue(" ", 1889, Html.Raw(d == 0 ? "active" : ""), 1890, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1924, 93, true);
            WriteLiteral(" data-slidename=\"slide_sale\" style=\"cursor:pointer\" data-boxtype=\"product_top_list\" data-id=\"");
            EndContext();
            BeginContext(2018, 7, false);
#line 51 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                                                                                                                                                                                          Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(2028, 9, false);
#line 51 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                                                                                                                                                                                                    Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(2037, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 52 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                                d += 1;
                            }
                        

#line default
#line hidden
            BeginContext(2142, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 56 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                }

#line default
#line hidden
            BeginContext(2189, 38, true);
            WriteLiteral("                <div class=\"option\">\r\n");
            EndContext();
            BeginContext(2301, 39, true);
            WriteLiteral("                    <a class=\"view-all\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2340, "\"", 2375, 2);
            WriteAttributeValue("", 2347, "/camp-all/", 2347, 10, true);
#line 59 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
WriteAttributeValue("", 2357, Model.campaign_id, 2357, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2376, 201, true);
            WriteLiteral(">Xem tất cả</a>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"swiper-container swiper-container-product-top\">\r\n                <div class=\"swiper-wrapper product_top_list\">\r\n");
            EndContext();
#line 66 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
                       await Html.RenderPartialAsync("/Views/Shared/Components/product/blog/product_top_list.cshtml", Model.product_list);

#line default
#line hidden
            BeginContext(2718, 266, true);
            WriteLiteral(@"                </div>
                <!-- Add Scrollbar -->
                <div class=""swiper-scrollbar""></div>
                <div class=""swiper-button-next""></div>
                <div class=""swiper-button-prev""></div>
            </div>
        </div>
");
            EndContext();
#line 74 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3008, 20, true);
            WriteLiteral("        <p>...</p>\r\n");
            EndContext();
#line 78 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\product\blog\product_top.cshtml"
    }
}

#line default
#line hidden
            BeginContext(3038, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB.UI.ViewModels.ProductTopEntitiesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
