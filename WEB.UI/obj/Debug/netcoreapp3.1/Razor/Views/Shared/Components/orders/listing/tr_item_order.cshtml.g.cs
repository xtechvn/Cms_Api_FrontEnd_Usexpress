#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97320e47a82d16d794c7299c33bb73fc17a10eda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_orders_listing_tr_item_order), @"mvc.1.0.view", @"/Views/Shared/Components/orders/listing/tr_item_order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/orders/listing/tr_item_order.cshtml", typeof(AspNetCore.Views_Shared_Components_orders_listing_tr_item_order))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
using WEB.UI.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97320e47a82d16d794c7299c33bb73fc17a10eda", @"/Views/Shared/Components/orders/listing/tr_item_order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_orders_listing_tr_item_order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItemHistoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#line 6 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(134, 89, true);
            WriteLiteral("        <tr class=\"tr_item_order\">\r\n            <td class=\"medium\"><a class=\"color_green\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 223, "\"", 257, 2);
            WriteAttributeValue("", 230, "/chi-tiet-don-hang-", 230, 19, true);
#line 9 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
WriteAttributeValue("", 249, item.id, 249, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(258, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(260, 12, false);
#line 9 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                                                                    Write(item.orderNo);

#line default
#line hidden
            EndContext();
            BeginContext(272, 50, true);
            WriteLiteral("</a></td>\r\n            <td class=\"list-product\">\r\n");
            EndContext();
#line 11 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                 if (item.product != null)
                {

#line default
#line hidden
            BeginContext(385, 26, true);
            WriteLiteral("                    <ul>\r\n");
            EndContext();
#line 14 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                          
                            int d = 0;
                            foreach (var product in item.product)
                            {

#line default
#line hidden
            BeginContext(577, 95, true);
            WriteLiteral("                                <li>\r\n                                    <div class=\"img\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 672, "\"", 697, 1);
#line 19 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
WriteAttributeValue("", 678, product.imageThumb, 678, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(698, 108, true);
            WriteLiteral("></div>\r\n                                    <div class=\"content\">\r\n                                        ");
            EndContext();
            BeginContext(807, 84, false);
#line 21 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                   Write(Html.Raw("<a href='/chi-tiet-don-hang-" + @item.id + "'>" + @product.title + "</a>"));

#line default
#line hidden
            EndContext();
            BeginContext(891, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 23 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                         if (item.product.Count > 1)
                                        {

#line default
#line hidden
            BeginContext(1008, 46, true);
            WriteLiteral("                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1054, "\"", 1088, 2);
            WriteAttributeValue("", 1061, "/chi-tiet-don-hang-", 1061, 19, true);
#line 25 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
WriteAttributeValue("", 1080, item.id, 1080, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1089, 76, true);
            WriteLiteral(" style=\"cursor: pointer;\">\r\n                                                ");
            EndContext();
            BeginContext(1166, 59, false);
#line 26 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                           Write(Html.Raw("... và " + item.product.Count + " sản phẩm khác"));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 52, true);
            WriteLiteral("\r\n                                            </a>\r\n");
            EndContext();
#line 28 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                            break;
                                        }

#line default
#line hidden
            BeginContext(1372, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1413, 17, false);
#line 30 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                   Write(Html.Raw("<br/>"));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1473, 33, false);
#line 31 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                   Write(Html.Raw("x " + product.quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 33 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                      
                                        if (d > 0)
                                        {
                                            

#line default
#line hidden
            BeginContext(1732, 17, false);
#line 36 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                       Write(Html.Raw("<br/>"));

#line default
#line hidden
            EndContext();
#line 36 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                                              ;
                                        }
                                        d += 1;
                                    

#line default
#line hidden
            BeginContext(1883, 39, true);
            WriteLiteral("                                </li>\r\n");
            EndContext();
#line 41 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1980, 27, true);
            WriteLiteral("                    </ul>\r\n");
            EndContext();
#line 44 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                }

#line default
#line hidden
            BeginContext(2026, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(2062, 29, false);
#line 46 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
           Write(item.amountVnd.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 46, true);
            WriteLiteral(" ₫</td>\r\n            <td class=\"text-right\">\r\n");
            EndContext();
#line 48 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                  
                    if (item.orderStatus == 3)
                    {
                        var create_order = Convert.ToDateTime(item.createdOn);
                        double total_hours = (DateTime.Now - create_order).TotalHours;
                        if (total_hours > 24)
                        {

#line default
#line hidden
            BeginContext(2470, 31, true);
            WriteLiteral("                            <p>");
            EndContext();
            BeginContext(2502, 19, false);
#line 55 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                          Write(Html.Raw("Hết hạn"));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 42, true);
            WriteLiteral("</p>\r\n                            <br />\r\n");
            EndContext();
#line 57 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                                                                                                
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2761, 31, true);
            WriteLiteral("                            <p>");
            EndContext();
            BeginContext(2793, 20, false);
#line 61 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                          Write(item.orderStatusName);

#line default
#line hidden
            EndContext();
            BeginContext(2813, 91, true);
            WriteLiteral("</p>\r\n                            <br />\r\n                            <a class=\"btn-detail\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2904, "\"", 2940, 2);
            WriteAttributeValue("", 2911, "/payment/re-checkout/", 2911, 21, true);
#line 63 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
WriteAttributeValue("", 2932, item.id, 2932, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2941, 51, true);
            WriteLiteral(" style=\"background:var(--green1);\">Thanh toán</a>\r\n");
            EndContext();
#line 64 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                        }
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(3116, 20, false);
#line 68 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                   Write(item.orderStatusName);

#line default
#line hidden
            EndContext();
#line 68 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
                                             
                    }
                

#line default
#line hidden
            BeginContext(3180, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 73 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
    }

#line default
#line hidden
#line 73 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\tr_item_order.cshtml"
     
}

#line default
#line hidden
            BeginContext(3224, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItemHistoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
