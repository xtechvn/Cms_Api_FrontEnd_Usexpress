#pragma checksum "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1a455eb1ed01eca449e826a4f2b93905a4caee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1a455eb1ed01eca449e826a4f2b93905a4caee", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/user.js?v=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 5707, true);
            WriteLiteral(@"<style>
    .info-detail .changer-admin .list li.active {
        background: #49b391;
        color: #fff;
    }

    .token-input-list {
        width: 100% !important;
    }
</style>

<div class=""row-main container flex"">
    <div class=""row-main_col200"">
        <h2 class=""title_page"">Người dùng</h2>
        <div class=""wrap_bg wrap_bg2"">
            <div class=""vai-tro"">
                <h3 class=""title-margin"">Vai trò</h3>
                <input type=""text"" id=""token-input-role"">
            </div>
        </div>
        <div class=""wrap_bg wrap_bg2"">
            <div class=""trang-thai"">
                <h3 class=""title-margin"">Trạng thái</h3>
                <label class=""radio radio-block"">
                    <input type=""radio"" name=""optradio"" onclick=""_user.OnChangeStatus(-1)"" checked=""checked"">
                    <span class=""checkmark""></span>
                    Tất cả
                </label>
                <label class=""radio radio-block"">
                    <in");
            WriteLiteral(@"put type=""radio"" name=""optradio"" onclick=""_user.OnChangeStatus(0)"">
                    <span class=""checkmark""></span>
                    Đang hoạt động
                </label>
                <label class=""radio radio-block"">
                    <input type=""radio"" name=""optradio"" onclick=""_user.OnChangeStatus(1)"">
                    <span class=""checkmark""></span>
                    Ngừng hoạt động
                </label>
            </div>
        </div>
    </div>

    <div class=""row-main_col800"">
        <div class=""flex row-main-head"">
            <div class=""search-wrapper"">
                <input type=""text"" class=""input_search onclick-togle"" id=""ip-kup-search-user"" placeholder=""Tên đăng nhập, người dùng"">
                <span class=""search-btn"">
                    <button type=""button"">
                        <svg class=""icon-svg"">
                            <use xlink:href=""images/icons/icon.svg#search""></use>
                        </svg>
                    </butt");
            WriteLiteral(@"on>
                </span>
            </div>
            <div class=""btn-right text-right"">
                <button class=""btn btn-default open-popup"" onclick=""_user.OnOpenCreateForm()"">
                    + Thêm mới
                </button>
                <div class=""down-up"">
                    <a class=""btn btn-default onclick"" href=""javascript:;"">
                        <i class=""fa fa-bars""></i>
                        <i class=""fa fa-caret-down""></i>
                    </a>
                    <div class=""form-down"">
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""checkbox-tb-column"" disabled=""disabled"" data-id=""2"" />
                            <span class=""checkmark""></span>
                            Tên đăng nhập
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""chec");
            WriteLiteral(@"kbox-tb-column"" disabled=""disabled"" data-id=""3"" />
                            <span class=""checkmark""></span>
                            Họ tên
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""checkbox-tb-column"" disabled=""disabled"" data-id=""4"" />
                            <span class=""checkmark""></span>
                            Điện thoại
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""checkbox-tb-column"" disabled=""disabled"" data-id=""5"" />
                            <span class=""checkmark""></span>
                            Ngày sinh
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""checkbox-tb-column"" disabled=""disabled"" data-i");
            WriteLiteral(@"d=""6"" />
                            <span class=""checkmark""></span>
                            Email
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" checked=""checked"" class=""checkbox-tb-column"" disabled=""disabled"" data-id=""7"" />
                            <span class=""checkmark""></span>
                            Vai trò
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" class=""checkbox-tb-column"" data-id=""8"" />
                            <span class=""checkmark""></span>
                            Địa chỉ
                        </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" class=""checkbox-tb-column"" data-id=""9"" />
                            <span class=""checkmark""></span>
                            Trạng thái
             ");
            WriteLiteral(@"           </label>
                        <label class=""check-list mb10 mr25"">
                            <input type=""checkbox"" class=""checkbox-tb-column"" data-id=""10"" />
                            <span class=""checkmark""></span>
                            Ngày tạo
                        </label>
                    </div>
                </div>
            </div>
        </div>
        <div class=""wrap_bg wrap_bg_no-padding mb20"">
            <div class=""table-responsive table-default"" id=""grid-data"">

            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5813, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5819, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1a455eb1ed01eca449e826a4f2b93905a4caee9976", async() => {
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
                BeginContext(5864, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
