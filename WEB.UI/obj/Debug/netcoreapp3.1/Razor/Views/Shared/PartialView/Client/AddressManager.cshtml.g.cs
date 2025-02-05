#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f35c92c1e59f81c10b905fdc972a1b647cdb2bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialView_Client_AddressManager), @"mvc.1.0.view", @"/Views/Shared/PartialView/Client/AddressManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialView/Client/AddressManager.cshtml", typeof(AspNetCore.Views_Shared_PartialView_Client_AddressManager))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
using Entities.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35c92c1e59f81c10b905fdc972a1b647cdb2bf1", @"/Views/Shared/PartialView/Client/AddressManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialView_Client_AddressManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AddressModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/address_manager/default.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
  
    ViewData["Title"] = "Địa chỉ giao hàng";
    Layout = null;
    bool is_has_address = true;

#line default
#line hidden
            BeginContext(162, 32, true);
            WriteLiteral("\r\n<ul class=\"pay-list-user\">\r\n\r\n");
            EndContext();
#line 11 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
     foreach (var item in Model.OrderByDescending(x => x.IsActive))
    {

#line default
#line hidden
            BeginContext(270, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 281, "\"", 328, 1);
#line 13 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
WriteAttributeValue("", 289, Html.Raw(item.IsActive?"checked":""), 289, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(329, 83, true);
            WriteLiteral(">\r\n            <div class=\"warp\">\r\n                <label class=\"lbl confir_res\">\r\n");
            EndContext();
#line 16 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                     if (item.IsActive)
                    {

#line default
#line hidden
            BeginContext(476, 71, true);
            WriteLiteral("                        <span class=\"default\">Địa chỉ mặc định</span>\r\n");
            EndContext();
#line 19 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(619, 73, true);
            WriteLiteral("                        <a class=\"delete delete_address\" data-addressid=\"");
            EndContext();
            BeginContext(693, 7, false);
#line 22 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(700, 209, true);
            WriteLiteral("\">\r\n                            <svg class=\"icon-us\">\r\n                                <use xlink:href=\"/images/icons/icon.svg#delete\"></use>\r\n                            </svg>\r\n                        </a>\r\n");
            EndContext();
#line 27 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                    }

#line default
#line hidden
            BeginContext(932, 24, true);
            WriteLiteral("                    <h3>");
            EndContext();
            BeginContext(957, 17, false);
#line 28 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                   Write(item.ReceiverName);

#line default
#line hidden
            EndContext();
            BeginContext(974, 78, true);
            WriteLiteral("</h3>\r\n                    <p>\r\n                        <span>Địa chỉ:</span> ");
            EndContext();
            BeginContext(1053, 16, false);
#line 30 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                         Write(item.FullAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 138, true);
            WriteLiteral("\r\n                    </p>\r\n                    <div class=\"bottom\">\r\n                        <div class=\"phone\"><span>Điện thoại:</span> ");
            EndContext();
            BeginContext(1208, 10, false);
#line 33 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                               Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 54, true);
            WriteLiteral("</div>\r\n                        <div class=\"option\">\r\n");
            EndContext();
#line 35 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                             if (item.IsActive && item.ProvinceId == null && item.DistrictId == null)
                            {
                                is_has_address = false;

#line default
#line hidden
            BeginContext(1463, 136, true);
            WriteLiteral("                                <a href=\"#usexpress-address-popup\" class=\"select edit btn_edit_address open-popup-link\" data-addressid=\"");
            EndContext();
            BeginContext(1600, 7, false);
#line 38 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 105, true);
            WriteLiteral("\">\r\n                                    Bổ sung địa chỉ giao hàng\r\n                                </a>\r\n");
            EndContext();
#line 41 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1808, 129, true);
            WriteLiteral("                                <a href=\"#usexpress-address-popup\" class=\"edit btn_edit_address open-popup-link\" data-addressid=\"");
            EndContext();
            BeginContext(1938, 7, false);
#line 44 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 174, true);
            WriteLiteral("\">\r\n                                    Chỉnh sửa\r\n                                </a>\r\n                                <a class=\"select btn_choice_address\" data-addressid=\"");
            EndContext();
            BeginContext(2120, 7, false);
#line 47 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2127, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(2141, 17, false);
#line 47 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                                     Write(item.ReceiverName);

#line default
#line hidden
            EndContext();
            BeginContext(2158, 14, true);
            WriteLiteral("\" data-phone=\"");
            EndContext();
            BeginContext(2173, 10, false);
#line 47 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                                                                     Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2183, 16, true);
            WriteLiteral("\" data-address=\"");
            EndContext();
            BeginContext(2200, 16, false);
#line 47 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                                                                                                                                                                Write(item.FullAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 105, true);
            WriteLiteral("\" href=\"#\">\r\n                                    Chọn địa chỉ này\r\n                                </a>\r\n");
            EndContext();
#line 50 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
                            }

#line default
#line hidden
            BeginContext(2352, 121, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </label>\r\n            </div>\r\n        </li>\r\n");
            EndContext();
#line 56 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
    }

#line default
#line hidden
            BeginContext(2480, 11, true);
            WriteLiteral("\r\n</ul>\r\n\r\n");
            EndContext();
#line 60 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
 if (is_has_address)
{

#line default
#line hidden
            BeginContext(2516, 168, true);
            WriteLiteral("    <div class=\"center mb30\">\r\n        <a href=\"#\" class=\"open-popup-link btn btn_edit_address\" data-addressid=\"-1\">+ &nbsp;Thêm địa chỉ giao hàng mới</a>\r\n    </div>\r\n");
            EndContext();
#line 65 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\PartialView\Client\AddressManager.cshtml"
}

#line default
#line hidden
            BeginContext(2687, 681, true);
            WriteLiteral(@"
<!--POPUP TẠO ĐỊA CHỈ GIAO HÀNG-->
<div id=""address-popup"" class=""address-popup white-popup mfp-hide""></div>
<!--END POPUP TẠO ĐỊA CHỈ GIAO HÀNG-->
<!--POPUP CONFIRM-->
<div id=""frm_delete_address_popup"" class=""notifi-popup white-popup medium-popup mfp-hide"">
    <div class=""content_poup"">
        <p class=""mb30"">Bạn có chắc chắn xóa địa chỉ này không ?</p>
        <div class=""control_btn row"">
            <div class=""col-xs-6""><button class=""btn full btn_confirm_delete_address"">Xóa</button></div>
            <div class=""col-xs-6""><button class=""btn full agray btn_destroy"">Trở lại</button></div>
        </div>
    </div>
</div>
<!--END POPUP CONFIRM-->


");
            EndContext();
            BeginContext(3368, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f35c92c1e59f81c10b905fdc972a1b647cdb2bf114537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3423, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AddressModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
