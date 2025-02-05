#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c72b245fead3d1cf31140de3458767b26ddb462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderHistory), @"mvc.1.0.view", @"/Views/Order/OrderHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderHistory.cshtml", typeof(AspNetCore.Views_Order_OrderHistory))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
using WEB.UI.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c72b245fead3d1cf31140de3458767b26ddb462", @"/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderManagerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/order/default.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "Quản lý đơn hàng";
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 559, true);
            WriteLiteral(@"
<link href=""/css/user.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""/css/order.css"" rel=""stylesheet"" type=""text/css"" />


<!-- MAIN CONTAINER -->
<section class=""main-container clearfix mt30"">
    <div class=""menu_control mb20"">
        <div class=""container"">
            <ul class=""breadcrumb"">
                <li><a href=""/"">Trang chủ</a></li>
                <li class=""active"">Quản lý đơn hàng</li>
            </ul>
        </div>
    </div>
    <div class=""container"">
        <div class=""user_management flex"">

          
");
            EndContext();
#line 26 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
               await Html.RenderPartialAsync("PartialView/Client/MenuClientManager", new ViewDataDictionary(this.ViewData) { { "client_name", Model.receiver_name } });

#line default
#line hidden
            BeginContext(883, 112, true);
            WriteLiteral("\r\n            <div class=\"sidebar2 padding_15\">\r\n                <div class=\"detail-dh\">\r\n\r\n                    ");
            EndContext();
            BeginContext(996, 151, false);
#line 31 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
               Write(await Component.InvokeAsync("ordersLast", new { view_comp = "/Views/Shared/Components/orders/order_last/default.cshtml", client_id = Model.client_id }));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 24, true);
            WriteLiteral("\r\n\r\n                    ");
            EndContext();
            BeginContext(1172, 143, false);
#line 33 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
               Write(await Component.InvokeAsync("ordersTab", new { view_comp = "/Views/Shared/Components/orders/tab/default.cshtml", client_id = Model.client_id }));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 327, true);
            WriteLiteral(@"

                    <div class=""flex space-between align-center order_control"">
                        <h2 class=""txt_18 medium mb10"">ĐƠN HÀNG CỦA TÔI</h2>
                        <div class=""search-wrapper mb15 control_search_order"">
                            <input type=""text"" class=""input_search txt_input_search""");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1642, "\"", 1649, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1650, "\"", 1658, 0);
            EndWriteAttribute();
            BeginContext(1659, 500, true);
            WriteLiteral(@" placeholder=""Nhập mã đơn hàng"">
                            <button class=""search-btn btn_search_order"">
                                <svg class=""icon-us"">
                                    <use xlink:href=""/images/icons/icon.svg#search""></use>
                                </svg>
                            </button>
                        </div>
                    </div>

                    <div class=""table-responsive table-default order_manager"">
                        ");
            EndContext();
            BeginContext(2160, 229, false);
#line 48 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderHistory.cshtml"
                   Write(await Component.InvokeAsync("ordersList", new { view_comp = "/Views/Shared/Components/orders/listing/default.cshtml", client_id = Model.client_id, order_status = -1, input_search = string.Empty, current_page = 1, page_size = 5 }));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 305, true);
            WriteLiteral(@"
                    </div>

                    <div class=""center btn_view_more_order"" style=""display:none;"">
                        <a class=""btn"" style=""width:282px"">Xem thêm</a>
                    </div>

                </div>
            </div>

        </div>
    </div>
</section>
");
            EndContext();
            BeginContext(2694, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c72b245fead3d1cf31140de3458767b26ddb4628110", async() => {
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
            BeginContext(2739, 31, true);
            WriteLiteral("\r\n<!-- END MAIN CONTAINER -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderManagerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
