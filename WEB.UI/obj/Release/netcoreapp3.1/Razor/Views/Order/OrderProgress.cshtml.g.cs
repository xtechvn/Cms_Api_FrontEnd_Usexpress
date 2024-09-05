#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5aeb93808b978318c8a7e9147192c1d7ef54901"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderProgress), @"mvc.1.0.view", @"/Views/Order/OrderProgress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderProgress.cshtml", typeof(AspNetCore.Views_Order_OrderProgress))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aeb93808b978318c8a7e9147192c1d7ef54901", @"/Views/Order/OrderProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderProgress.cshtml"
  
    int order_status = (int)this.ViewData["order_status"];
    int payment_status = (int)this.ViewData["payment_status"];

#line default
#line hidden
            BeginContext(131, 252, true);
            WriteLiteral("\r\n<div class=\"time_ship step-dh flex\">\r\n\r\n    <div class=\"step step1\">\r\n        <div class=\"icon\">\r\n            <svg class=\"icon-us\">\r\n                <use xlink:href=\"/images/icons/icon.svg#payment\"></use>\r\n            </svg>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(384, 80, false);
#line 14 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderProgress.cshtml"
   Write(Html.Raw(payment_status == 0 ? "<p>Đã thanh toán</p>" : "<p>Chờ thanh toán</p>"));

#line default
#line hidden
            EndContext();
            BeginContext(464, 1483, true);
            WriteLiteral(@"
        <span class=""p_0""></span>
    </div>
    <div class=""step step2"">
        <div class=""icon"">
            <svg class=""icon-us"">
                <use xlink:href=""/images/icons/icon.svg#plane""></use>
            </svg>
        </div>
        <p>Hàng về kho Mỹ</p>
        <span class=""p_1""></span>
    </div>
    <div class=""step step3"">
        <div class=""icon"">
            <svg class=""icon-us"">
                <use xlink:href=""/images/icons/icon.svg#plane""></use>
            </svg>
        </div>
        <p>Hàng về Việt Nam</p>
        <span class=""p_2""></span>
    </div>
    <div class=""step step4"">
        <div class=""icon"">
            <svg class=""icon-us"">
                <use xlink:href=""/images/icons/icon.svg#shipped""></use>
            </svg>
        </div>
        <p>Thông quan</p>
        <span class=""p_3""></span>
    </div>
    <div class=""step step5"">
        <div class=""icon"">
            <svg class=""icon-us"">
                <use xlink:href=""/images/icons/i");
            WriteLiteral(@"con.svg#box""></use>
            </svg>
        </div>
        <p>Giao hàng</p>
        <span></span>
    </div>
</div>


<script type=""text/javascript"">
    $(document).ready(function () {

        var arr_status = new Array(""_13_6_"", ""_9_"", ""_10_"", ""_11_7_"", ""_4_"");// đơn hàng mới |  đơn hàng đã mua trên amazon |  Hàng đang chuyển về VN | Hàng đang chuyển về VN | Đơn hàng hoàn thành(Giao hàng thành công)
        var order_status = parseInt('");
            EndContext();
            BeginContext(1948, 12, false);
#line 60 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Order\OrderProgress.cshtml"
                                Write(order_status);

#line default
#line hidden
            EndContext();
            BeginContext(1960, 1539, true);
            WriteLiteral(@"');
        
        //debugger;
        var status_current = arr_status.find(x => x.indexOf(""_"" + order_status + ""_"") >= 0);
        var step = arr_status.indexOf(status_current);

       //var data_log = getOrderProgress('UAM-1B24241');
        //data_log = JSON.stringify(data_log);

       // var i_index = arr_status.indexOf(parseInt(step));
        for (var i = 0; i <= step; i++) {
            $('.time_ship').find('.step').eq(i).addClass('active');
            if (i <= step - 1) {
                $('.time_ship').find('.step').eq(i).addClass('success');
                
                //var log_order = JSON.parse(JSON.parse(data_log).responseText).data;
             
                //if (log_order.length > 0) {
                //    for (var j = 0; j <= log_order.length - 1; j++) {
                //        if (arr_status[i].indexOf(""_"" + log_order[j].orderStatus + ""_"") >= 0){
                //            $("".p_"" + i).html(log_order[j].createDate);
                //            cont");
            WriteLiteral(@"inue;
                //        }
                //    }
                //}
            }
        }
    })

    function getOrderProgress(order_no) {
        return $.ajax({
            type: ""POST"",
            url: '/order/order-progress.json',
            data: {
                order_no: order_no
            },
            dataType: ""html"",
            async: !1,
            error: function () {
                console.log(""Error occured"")
            }
        });
    }

</script>");
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
