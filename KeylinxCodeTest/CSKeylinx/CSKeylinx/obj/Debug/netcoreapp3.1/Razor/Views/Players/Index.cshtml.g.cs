#pragma checksum "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57f79752bf15baa596d75984dd5587544df426e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Index), @"mvc.1.0.view", @"/Views/Players/Index.cshtml")]
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
#nullable restore
#line 1 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\_ViewImports.cshtml"
using CSKeylinx;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\_ViewImports.cshtml"
using CSKeylinx.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57f79752bf15baa596d75984dd5587544df426e", @"/Views/Players/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fea48889c7b73f17cfab1df60e6f5d7dfff4296", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CSKeylinx.Models.Players>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
  
    ViewData["Title"] = "Players";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<blockquote class=\"blockquote text-center\">\r\n    <h1 class=\"display-4\">Players</h1>\r\n</blockquote>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Clan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Clan.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Players\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CSKeylinx.Models.Players>> Html { get; private set; }
    }
}
#pragma warning restore 1591
