#pragma checksum "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffa52ae4f0fc2c567b54af95384b75d2629e016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopBar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopBar_Default))]
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
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\_ViewImports.cshtml"
using WEB.CMS;

#line default
#line hidden
#line 2 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\_ViewImports.cshtml"
using WEB.CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ffa52ae4f0fc2c567b54af95384b75d2629e016", @"/Views/Shared/Components/TopBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml"
  
    var _RateCurrent = (double)ViewBag.RateCurrent;
    var userId = int.Parse(ViewBag.UserId);

#line default
#line hidden
            BeginContext(105, 509, true);
            WriteLiteral(@"<section id=""topbar"" class=""section top_bar"">
    <div class=""flex container align-center"">
        <a href=""javascript:;"" class=""all-menu all-menu-tablet""><span class=""hamburger""></span></a>
        <a class=""logo"" href=""/""><img src=""/images/graphics/logo.svg""></a>
        <div class=""header-right"">
            <ul>
                <li class=""ty-gia"">
                    <div class=""color-main txt_11"">(Lấy theo Vietcombank)</div>
                    <div class=""txt_666 txt_14"">Tỷ giá $ hôm nay: ");
            EndContext();
            BeginContext(615, 42, false);
#line 13 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml"
                                                             Write(Math.Round(_RateCurrent, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(657, 33, true);
            WriteLiteral(" đ</div>\r\n                </li>\r\n");
            EndContext();
#line 15 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml"
                 if (userId != 54)
                {

#line default
#line hidden
            BeginContext(745, 877, true);
            WriteLiteral(@"                    <li class=""setting"">
                        <a class=""cur-pointer"" onclick=""_productCost.OnOpenForm();"">
                            <strong>Báo giá</strong>
                            <i class=""fa fa-calculator text-secondary""></i>
                        </a>
                    </li>
                    <li class=""setting"">

                        <a href=""javascript:void(0);"">
                            <strong>Thiết lập</strong>
                            <i class=""iconfont-setting""></i>
                        </a>
                        <ul class=""sub-menu"">
                            <li><a href=""/user""><i class=""fa fa-user""></i>Quản lý người dùng</a></li>
                            <li><a href=""/role""><i class=""fa fa-reply-all""></i>Phân quyền nhóm</a></li>
                        </ul>
                    </li>
");
            EndContext();
#line 34 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1641, 149, true);
            WriteLiteral("\r\n                <li class=\"user-name menu-bar onclick-togle\">\r\n                    <a class=\"lk-user-name\">\r\n                        <strong>Chào: ");
            EndContext();
            BeginContext(1791, 16, false);
#line 38 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\TopBar\Default.cshtml"
                                 Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1807, 132, true);
            WriteLiteral("</strong>\r\n                        <i class=\"fa fa-user\"></i>\r\n                    </a>\r\n                    <ul class=\"sub-menu\">\r\n");
            EndContext();
            BeginContext(2693, 206, true);
            WriteLiteral("                        <li><a onclick=\"_account.OnGetDatailUser()\" style=\"cursor:pointer\"><i class=\"fa fa-user\"></i> Thông tin tài khoản</a></li>\r\n                        <li>\r\n                            ");
            EndContext();
            BeginContext(2899, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffa52ae4f0fc2c567b54af95384b75d2629e0168000", async() => {
                BeginContext(2964, 181, true);
                WriteLiteral("\r\n                                <a onclick=\"$(this).closest(\'form\').submit()\" style=\"cursor:pointer\"><i class=\"fa fa-external-link\"></i>Đăng xuất</a>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3152, 140, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</section>");
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
