#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Payment\AddressReceiver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3353a102442db0caf13b034930322c4d0dce4306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialView_Payment_AddressReceiver), @"mvc.1.0.view", @"/Views/Shared/PartialView/Payment/AddressReceiver.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialView/Payment/AddressReceiver.cshtml", typeof(AspNetCore.Views_Shared_PartialView_Payment_AddressReceiver))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3353a102442db0caf13b034930322c4d0dce4306", @"/Views/Shared/PartialView/Payment/AddressReceiver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialView_Payment_AddressReceiver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 907, true);
            WriteLiteral(@"<div class=""checkout_sidebar"">    
    <a href=""#"" class=""edit btn_edit_address open-popup-link"" data-addressid=""-1"">
            <svg class=""icon-us"">
                <use xlink:href=""~/images/icons/icon.svg#edit""></use>
            </svg>Sửa
        </a>
        <h3 class=""title"">THÔNG TIN GIAO HÀNG</h3>
        <div class=""checkout_tr info_delivery"">
            <div class=""item placeholder"">
                <p class=""txt_666"">Họ tên khách hàng :</p>
                <div class=""delivery_name""></div>
            </div>
            <div class=""item placeholder"">
                <p class=""txt_666"">Số điện thoại :</p>
                <span class=""delivery_phone""></span>
            </div>
            <div class=""item placeholder"">
                <p class=""txt_666"">Địa chỉ :</p>
                <span class=""delivery_address""></span>
            </div>
        </div>
</div>
");
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
