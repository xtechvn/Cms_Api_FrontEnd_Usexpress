#pragma checksum "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ea7f2e3ce6cd8c18a658d520369e8183b96aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_orders_tab_default), @"mvc.1.0.view", @"/Views/Shared/Components/orders/tab/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/orders/tab/default.cshtml", typeof(AspNetCore.Views_Shared_Components_orders_tab_default))]
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
#line 1 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
using Entities.ViewModels.Orders;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ea7f2e3ce6cd8c18a658d520369e8183b96aac", @"/Views/Shared/Components/orders/tab/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1035fdfdc4969c7222edfc34e6acaeba143f6d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_orders_tab_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderTabModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
 if (Model != null)
{
    int d = 0;

#line default
#line hidden
            BeginContext(106, 41, true);
            WriteLiteral("    <div class=\"tab-default tab_order\">\r\n");
            EndContext();
#line 8 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(196, 27, true);
            WriteLiteral("            <a data-index=\"");
            EndContext();
            BeginContext(224, 14, false);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
                      Write(item.tab_index);

#line default
#line hidden
            EndContext();
            BeginContext(238, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 239, "\"", 250, 2);
            WriteAttributeValue("", 244, "tab_", 244, 4, true);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
WriteAttributeValue("", 248, d, 248, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 14, true);
            WriteLiteral("  data-count=\"");
            EndContext();
            BeginContext(266, 16, false);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
                                                                Write(item.order_count);

#line default
#line hidden
            EndContext();
            BeginContext(282, 26, true);
            WriteLiteral("\"  style=\"cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 308, "\"", 364, 2);
            WriteAttributeValue("", 316, "tab_order_status", 316, 16, true);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
WriteAttributeValue(" ", 332, Html.Raw(d == 0 ? "active":""), 333, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(367, 13, false);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
                                                                                                                                                                     Write(item.tab_name);

#line default
#line hidden
            EndContext();
            BeginContext(380, 8, true);
            WriteLiteral(" <strong");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 388, "\"", 402, 2);
            WriteAttributeValue("", 396, "tab_", 396, 4, true);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
WriteAttributeValue("", 400, d, 400, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(403, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(406, 16, false);
#line 10 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
                                                                                                                                                                                                            Write(item.order_count);

#line default
#line hidden
            EndContext();
            BeginContext(422, 16, true);
            WriteLiteral(")</strong></a>\r\n");
            EndContext();
#line 11 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
            d += 1;
        }     

#line default
#line hidden
            BeginContext(475, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 14 "F:\PROJECT\MY_PROJECT\SOURCE_NEW\WEB\WEB.UI\Views\Shared\Components\orders\tab\default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderTabModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
