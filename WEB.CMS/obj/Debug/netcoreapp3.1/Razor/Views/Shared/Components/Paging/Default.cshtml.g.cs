#pragma checksum "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393ea2b7a875258435c727abc0e6f5b1db653449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Paging_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Paging/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Paging/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Paging_Default))]
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
#line 1 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
using Entities.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393ea2b7a875258435c727abc0e6f5b1db653449", @"/Views/Shared/Components/Paging/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e716c65ce070a68220f96d594a09ccb00e6e6e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Paging_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paging>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
 if (Model.TotalRecord > 0)
{

#line default
#line hidden
            BeginContext(75, 111, true);
            WriteLiteral("    <ul id=\"pagination\" class=\"pagination\">\r\n\r\n        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 186, "\"", 230, 1);
#line 8 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 196, string.Format(Model.PageAction,1), 196, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(231, 109, true);
            WriteLiteral(">\r\n                <i class=\"fa fa-step-backward\">\r\n                </i>\r\n            </a>\r\n        </li>\r\n\r\n");
            EndContext();
#line 14 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
         if (Model.CurrentPage == 1)
        {

#line default
#line hidden
            BeginContext(389, 177, true);
            WriteLiteral("            <li class=\"page-item\">\r\n\r\n                <a class=\"page-link icon\">\r\n                    <i class=\"fa fa-caret-left\"></i>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 22 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(602, 77, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link icon\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 679, "\"", 741, 1);
#line 26 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 689, string.Format(Model.PageAction,Model.CurrentPage-1), 689, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(742, 98, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-caret-left\"></i>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 30 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(851, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
          
            int _from = 0, _to = 0;
            if (Model.CurrentPage == 1)
            {
                _from = 1;
                _to = Model.TotalPage > 3 ? 3 : Model.TotalPage;
            }
            else if (Model.CurrentPage == Model.TotalPage)
            {
                _from = Model.TotalPage > 3 ? Model.CurrentPage - 2 : 1;
                _to = Model.TotalPage;
            }
            else
            {
                _from = Model.CurrentPage - 1;
                _to = Model.CurrentPage + 1;
            }
        

#line default
#line hidden
            BeginContext(1424, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
         for (int i = _from; i <= _to; i++)
        {

#line default
#line hidden
            BeginContext(1482, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1497, "\"", 1553, 2);
            WriteAttributeValue("", 1505, "page-item", 1505, 9, true);
#line 53 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue(" ", 1514, i == Model.CurrentPage ?"active":"", 1515, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1554, 21, true);
            WriteLiteral("><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1575, "\"", 1619, 1);
#line 53 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 1585, string.Format(Model.PageAction,i), 1585, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1620, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1622, 1, false);
#line 53 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 54 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
         if (Model.CurrentPage == Model.TotalPage)
        {

#line default
#line hidden
            BeginContext(1710, 176, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link icon\">\r\n                    <i class=\"fa fa-caret-right\"></i>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 63 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1922, 77, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link icon\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1999, "\"", 2061, 1);
#line 67 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 2009, string.Format(Model.PageAction,Model.CurrentPage+1), 2009, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2062, 99, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-caret-right\"></i>\r\n                </a>\r\n            </li>\r\n");
            EndContext();
#line 71 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(2172, 66, true);
            WriteLiteral("\r\n        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2238, "\"", 2296, 1);
#line 74 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 2248, string.Format(Model.PageAction,Model.TotalPage), 2248, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2297, 111, true);
            WriteLiteral(">\r\n                <i class=\"fa fa-step-forward\"></i>\r\n            </a>\r\n        </li>\r\n        <span>Hiển thị ");
            EndContext();
            BeginContext(2410, 44, false);
#line 78 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
                   Write((Model.CurrentPage - 1) * Model.PageSize + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2455, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2460, 34, false);
#line 78 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
                                                                     Write(Model.CurrentPage * Model.PageSize);

#line default
#line hidden
            EndContext();
            BeginContext(2495, 14, true);
            WriteLiteral(" trên tổng số ");
            EndContext();
            BeginContext(2510, 17, false);
#line 78 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
                                                                                                                       Write(Model.TotalRecord);

#line default
#line hidden
            EndContext();
            BeginContext(2527, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2529, 16, false);
#line 78 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
                                                                                                                                          Write(Model.RecordName);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 21, true);
            WriteLiteral(".</span>\r\n    </ul>\r\n");
            EndContext();
#line 80 "E:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.CMS\Views\Shared\Components\Paging\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paging> Html { get; private set; }
    }
}
#pragma warning restore 1591
