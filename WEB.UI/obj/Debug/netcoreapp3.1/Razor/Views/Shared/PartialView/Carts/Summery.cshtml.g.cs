#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Carts\Summery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ccf9a171759f0fc2178d0cabc829d11ebf4d4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialView_Carts_Summery), @"mvc.1.0.view", @"/Views/Shared/PartialView/Carts/Summery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialView/Carts/Summery.cshtml", typeof(AspNetCore.Views_Shared_PartialView_Carts_Summery))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ccf9a171759f0fc2178d0cabc829d11ebf4d4d", @"/Views/Shared/PartialView/Carts/Summery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialView_Carts_Summery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1054, true);
            WriteLiteral(@"<div class=""checkout_sidebar"">
    <div class=""checkout_tr"">
        <div class=""item"">
            <p>Tiền hàng :</p>
            <span class=""price total_amount_vnd"" >0 <em>đ</em></span>
        </div>
        <div class=""item"">
            <p>Giảm giá :</p>
            <span class=""price total_discount_amount"">0 <em>đ</em></span>
        </div>
        <div class=""item  price_all"">
            <p><strong>TỔNG TIỀN</strong> (tạm tính) </p>
            <strong class=""price total_amount_last_vnd"">0 <em>đ</em></strong>
        </div>
    </div>
    <div class=""clearfix""></div>
    <a class=""btn btn-order btn-confirm-cart"">XÁC NHẬN GIỎ HÀNG</a>
</div>

<script type=""text/javascript"">
    $('.btn-confirm-cart').click(function () {
        
        var item_check = $('input:checkbox:checked').length;
        if (item_check == 0) {
            alert(""Bạn vẫn chưa chọn sản phẩm nào để mua."");
            return;
        } else {
            window.location.href = ""/payment/checkout"";
   ");
            WriteLiteral("     }\r\n    });\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
