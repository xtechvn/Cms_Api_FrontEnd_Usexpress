#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Client\ExpireChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0987387df4c9dc0c2cbefc1b1feb5ca123179ef3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ExpireChangePassword), @"mvc.1.0.view", @"/Views/Client/ExpireChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/ExpireChangePassword.cshtml", typeof(AspNetCore.Views_Client_ExpireChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0987387df4c9dc0c2cbefc1b1feb5ca123179ef3", @"/Views/Client/ExpireChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_ExpireChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1196, true);
            WriteLiteral(@"<section class=""main-container clearfix mt30"">
    <div class=""menu_control mb20"">
        <div class=""container"">
            <ul class=""breadcrumb"">
                <li><a href=""/"">Trang chủ</a></li>
                <li class=""active"">Đổi mật khẩu</li>
            </ul>
        </div>
    </div>
    <div class=""container page-payer"">
        <div class=""bg_warp bg_changer_pass mb25"">
            <div class=""text_line margin"">
                <svg class=""icon-us"">
                    <use xlink:href=""#padlock""></use>
                </svg>Lấy lại mật khẩu
            </div>
            <p class=""mb20"">Nếu bạn chưa có tài khoản hãy <a href=""#login-popup"" class=""color_green2"">đăng ký</a></p>
            <div class=""row"">
                <div class=""col-md-5"">
                    <div class=""bg_notifi1"">
                        Link thay đổi mật khẩu không đúng hoặc đã hết hiệu lực. Để thay đổi vui lòng click
                        vào <a href=""#login-popup"" class=""color_green2"">đây</a> để");
            WriteLiteral("\r\n                        lấy link khởi tạo mật khẩu\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>        \r\n    </div>\r\n</section>");
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
