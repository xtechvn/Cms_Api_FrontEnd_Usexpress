#pragma checksum "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b4936705d8ced16acff55d0c93f59e7562066c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Payment), @"mvc.1.0.view", @"/Views/Order/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Payment.cshtml", typeof(AspNetCore.Views_Order_Payment))]
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
#line 4 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
using Utilities;

#line default
#line hidden
#line 5 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
using Entities.Models;

#line default
#line hidden
#line 6 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
using Entities.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b4936705d8ced16acff55d0c93f59e7562066c", @"/Views/Order/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PaymentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
  
    Layout = null;

#line default
#line hidden
#line 8 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
  
    // var _ListProduct = (List<OrderItemViewModel>)ViewBag.ListProduct;
    var _ListPaymentType = (List<AllCode>)ViewBag.ListPaymentType;
    var _UserLogin = (int)ViewBag.UserLogin;

#line default
#line hidden
            BeginContext(323, 1594, true);
            WriteLiteral(@"
<div class=""title-cate"">
    <span>Số lần thanh toán</span>
</div>
<div class=""warp_padding20"">
    <div class=""wrap_bg wrap_bg_no-padding mb20"">
        <div class=""table-responsive table-default"">
            <table class=""table table-nowrap text-center"">
                <thead>
                    <tr style=""background: #ECECEE;"">
                        <th>STT</th>
                        <th>Pay Id</th>
                        <th style=""width: 180px;"">Ngày chuyển</th>
                        <th style=""width: 180px;"">Số tiền chuyển</th>
                        <th>Nguồn chuyển</th>
                        <th>Ghi chú</th>
                        <th>Tác vụ</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>
                            <div class=""datepicker-wrap"" style=""width:100%"">
                                <input type=""hi");
            WriteLiteral(@"dden"" id=""model-payment-id"" />
                                <input type=""text"" class=""datepicker-input form-control"" id=""model-payment-date"" />
                            </div>
                        </td>
                        <td>
                            <div class=""form-group mb0"">
                                <input type=""text"" class=""form-control currency"" id=""model-payment-amount"" />
                            </div>
                        </td>
                        <td>
                            <div class=""form-group mb0"">
");
            EndContext();
            BeginContext(2429, 147, true);
            WriteLiteral("\r\n                                <select class=\"form-control\" style=\"height: 30px;\" id=\"model-payment-type\">\r\n                                    ");
            EndContext();
            BeginContext(2576, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b4936705d8ced16acff55d0c93f59e7562066c6244", async() => {
                BeginContext(2594, 20, true);
                WriteLiteral("Hình thức thanh toán");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2623, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                     foreach (var item in _ListPaymentType)
                                    {

#line default
#line hidden
            BeginContext(2741, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2781, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b4936705d8ced16acff55d0c93f59e7562066c8007", async() => {
                BeginContext(2814, 16, false);
#line 61 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                                                   Write(item.Description);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 61 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                           WriteLiteral(item.CodeValue);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2839, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2880, 726, true);
            WriteLiteral(@"                                </select>
                            </div>
                        </td>
                        <td>
                            <div class=""form-group mb0"">
                                <input type=""text"" class=""form-control"" id=""model-payment-note"" />
                            </div>
                        </td>
                        <td>
                            <a class=""cur-pointer mr10"" onclick=""_payment.Save()"" title=""Lưu""><i class=""fa fa-save blue""></i></a>
                            <a class=""cur-pointer"" onclick=""_payment.ResetForm();"" title=""Refresh""><i class=""fa fa-refresh success""></i></a>
                        </td>
                    </tr>
");
            EndContext();
#line 76 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                     if (Model != null && Model.Count > 0)
                    {
                        var count = 0;
                        foreach (var item in Model)
                        {
                            count++;

#line default
#line hidden
            BeginContext(3847, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3918, 5, false);
#line 83 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(3923, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3967, 7, false);
#line 84 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3974, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4018, 45, false);
#line 85 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(item.PaymentDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(4063, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4107, 41, false);
#line 86 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(StringHelpers.FormatCurrency(item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(4148, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4192, 20, false);
#line 87 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(item.PaymentTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(4212, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4256, 9, false);
#line 88 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                               Write(item.Note);

#line default
#line hidden
            EndContext();
            BeginContext(4265, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 90 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                     if (item.UserId == _UserLogin)
                                    {

#line default
#line hidden
            BeginContext(4418, 67, true);
            WriteLiteral("                                        <a class=\"cur-pointer mr10\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4485, "\"", 4627, 11);
            WriteAttributeValue("", 4495, "_payment.FillUpdateItem(\'", 4495, 25, true);
#line 92 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4520, item.Id, 4520, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4528, "\',\'", 4528, 3, true);
#line 92 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4531, item.PaymentDate.ToString("dd/MM/yyyy HH:mm"), 4531, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 4577, "\',\'", 4577, 3, true);
#line 92 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4580, item.PaymentType, 4580, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 4597, "\',\'", 4597, 3, true);
#line 92 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4600, item.Amount, 4600, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 4612, "\',\'", 4612, 3, true);
#line 92 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4615, item.Note, 4615, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 4625, "\')", 4625, 2, true);
            EndWriteAttribute();
            BeginContext(4628, 190, true);
            WriteLiteral(">\r\n                                            <i class=\"fa fa-pencil blue\"></i>\r\n                                        </a>\r\n                                        <a class=\"cur-pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4818, "\"", 4855, 3);
            WriteAttributeValue("", 4828, "_payment.Delete(\'", 4828, 17, true);
#line 95 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4845, item.Id, 4845, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4853, "\')", 4853, 2, true);
            EndWriteAttribute();
            BeginContext(4856, 38, true);
            WriteLiteral("><i class=\"fa fa-times red\"></i></a>\r\n");
            EndContext();
#line 96 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4933, 74, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 99 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                        }

#line default
#line hidden
            BeginContext(5034, 397, true);
            WriteLiteral(@"                        <tr style=""background: #E1E8EA;"">
                            <td></td>
                            <td style=""padding: 20px 15px;"">
                                <strong>Tổng cộng:</strong>
                            </td>
                            <td></td>
                            <td style=""padding: 20px 15px;"">
                                <strong>");
            EndContext();
            BeginContext(5432, 54, false);
#line 107 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                                   Write(StringHelpers.FormatCurrency(Model.Sum(s => s.Amount)));

#line default
#line hidden
            EndContext();
            BeginContext(5486, 194, true);
            WriteLiteral("</strong>\r\n                            </td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                        </tr>\r\n");
            EndContext();
#line 113 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Order\Payment.cshtml"
                    }

#line default
#line hidden
            BeginContext(5703, 334, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $('.datepicker-input').Zebra_DatePicker({
            format: 'd/m/Y H:i',
            onSelect: function () {
                $(this).change();
            }
        });
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PaymentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
