#pragma checksum "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa5f5317ab27d0e4cd9c7cbaf0381f5bbb4e24b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#line 2 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa5f5317ab27d0e4cd9c7cbaf0381f5bbb4e24b", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
  
    var listMenu = (List<Entities.ViewModels.MenuViewModel>)ViewBag.Menu;
    var userId = int.Parse(ViewBag.UserId);

#line default
#line hidden
            BeginContext(192, 239, true);
            WriteLiteral("<section class=\"section head-top\">\r\n    <div class=\"flex container\">\r\n        <div class=\"header-tab tab-default\">\r\n            <ul class=\"flex\">\r\n                <li>\r\n                    <a href=\"/\">Trang chủ</a>\r\n                </li>\r\n");
            EndContext();
#line 14 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                 foreach (var item in listMenu)
                {
                    

#line default
#line hidden
#line 16 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                     if (userId == 54)
                    {
                        if (item.Parent.Id == 1)
                        {


#line default
#line hidden
            BeginContext(641, 68, true);
            WriteLiteral("                            <li>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 709, "\"", 733, 1);
#line 22 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 716, item.Parent.Link, 716, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(734, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(736, 16, false);
#line 22 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                       Write(item.Parent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(752, 59, true);
            WriteLiteral("</a>\r\n                                <ul class=\"lever2\">\r\n");
            EndContext();
#line 24 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                     foreach (var subMenu in item.ChildList)
                                    {

#line default
#line hidden
            BeginContext(928, 92, true);
            WriteLiteral("                                        <li>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1040, 1);
#line 27 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1027, subMenu.Link, 1027, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1041, 3, true);
            WriteLiteral("><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1044, "\"", 1065, 1);
#line 27 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1052, subMenu.Icon, 1052, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1066, 11, true);
            WriteLiteral("></i>&nbsp;");
            EndContext();
            BeginContext(1078, 12, false);
#line 27 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                  Write(subMenu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 53, true);
            WriteLiteral("</a>\r\n                                        </li>\r\n");
            EndContext();
#line 29 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1182, 74, true);
            WriteLiteral("                                </ul>\r\n                            </li>\r\n");
            EndContext();
#line 32 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1355, 60, true);
            WriteLiteral("                        <li>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1415, "\"", 1439, 1);
#line 37 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1422, item.Parent.Link, 1422, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1440, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1442, 16, false);
#line 37 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                   Write(item.Parent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 55, true);
            WriteLiteral("</a>\r\n                            <ul class=\"lever2\">\r\n");
            EndContext();
#line 39 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                 foreach (var subMenu in item.ChildList)
                                {

#line default
#line hidden
            BeginContext(1622, 84, true);
            WriteLiteral("                                    <li>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1726, 1);
#line 42 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1713, subMenu.Link, 1713, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1727, 3, true);
            WriteLiteral("><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1730, "\"", 1751, 1);
#line 42 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 1738, subMenu.Icon, 1738, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1752, 11, true);
            WriteLiteral("></i>&nbsp;");
            EndContext();
            BeginContext(1764, 12, false);
#line 42 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                                                                              Write(subMenu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 49, true);
            WriteLiteral("</a>\r\n                                    </li>\r\n");
            EndContext();
#line 44 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                                }

#line default
#line hidden
            BeginContext(1860, 66, true);
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
            EndContext();
#line 47 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#line 79 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Menu\Default.cshtml"
                           

                }

#line default
#line hidden
            BeginContext(3545, 1442, true);
            WriteLiteral(@"            </ul>
        </div>
        <div class=""wrap-notifi"">
            <a class=""notifi"" href=""#"">
                <i class=""fa fa-bell-o""></i>
                <span class=""coutn"">8</span>
                <span>Thông báo</span>
            </a>
            <div class=""list"">
                <span class=""note"">Thông báo từ hệ thống</span>
                <ul>
                    <li class=""active"">
                        <a href=""#"">
                            <strong class=""color-main"">cuongle</strong> vừa thêm 2 sản phẩm vào giỏ hàng cách đây 15
                            phút nhưng chưa tạo đơn
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            Đơn UAM-8B858 được khởi tạo thành công cách đây 1 tiếng nhưng chưa thanh
                            toán
                        </a>
                    </li>
                    <li>
                        <a>
                         ");
            WriteLiteral(@"   Sản phẩm <span class=""color-main"">
                                Kirkland Signature Ibuprofen IB, 200 mg., 1,000
                                Caplets
                            </span> vừa được published
                        </a>
                    </li>
                </ul>
                <a class=""view-all"" href=""#"">Xem tất cả</a>
            </div>
        </div>
    </div>
</section>
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
