#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7812ffc1c01614609176f920c67559981cc9fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_orders_listing_default), @"mvc.1.0.view", @"/Views/Shared/Components/orders/listing/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/orders/listing/default.cshtml", typeof(AspNetCore.Views_Shared_Components_orders_listing_default))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\default.cshtml"
using WEB.UI.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7812ffc1c01614609176f920c67559981cc9fc7", @"/Views/Shared/Components/orders/listing/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_orders_listing_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItemHistoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\default.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(93, 112, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th width=\"16%\">Mã đơn hàng</th>\r\n");
            EndContext();
            BeginContext(256, 251, true);
            WriteLiteral("                <th width=\"49%\">Sản phẩm</th>\r\n                <th width=\"15%\">Tổng tiền</th>\r\n                <th width=\"20%\" class=\"text-right\">Trạng thái</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\"tb_order_item\">            \r\n");
            EndContext();
#line 17 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\default.cshtml"
               await Html.RenderPartialAsync("/Views/Shared/Components/orders/listing/tr_item_order.cshtml", Model); 

#line default
#line hidden
            BeginContext(627, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 20 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\listing\default.cshtml"
}

#line default
#line hidden
            BeginContext(662, 2, true);
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
