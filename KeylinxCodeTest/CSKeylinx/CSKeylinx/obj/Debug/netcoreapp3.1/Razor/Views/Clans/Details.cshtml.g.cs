#pragma checksum "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23ba22c3457fe2a1961f77c6de045cf54c99b4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clans_Details), @"mvc.1.0.view", @"/Views/Clans/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23ba22c3457fe2a1961f77c6de045cf54c99b4a", @"/Views/Clans/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fea48889c7b73f17cfab1df60e6f5d7dfff4296", @"/Views/_ViewImports.cshtml")]
    public class Views_Clans_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CSKeylinx.Models.Players>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("playerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
  
    ViewData["Title"] = "Details";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<blockquote class=\"blockquote text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 9 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
                     Write(ViewBag.Clan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</blockquote>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Player ID\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 745, "\"", 758, 1);
#nullable restore
#line 33 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
WriteAttributeValue("", 750, item.Id, 750, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 34 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d23ba22c3457fe2a1961f77c6de045cf54c99b4a6867", async() => {
                WriteLiteral(@"
            <div class=""text-danger""></div>
            <div class=""form-group"">
                <p>Player ID</p>
                <label class=""control-label""></label>
                <input name=""id"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <p>Score</p>
                <label class=""control-label""></label>
                <input name=""score"" class=""form-control"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <a href=""#"" class=""btn btn-primary"" onclick=""SavePlayerScore()""> Submit Score</a>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function SavePlayerScore() {\r\n\r\n            var playerId = $(\'[name=id]\').val();\r\n            var playerScore = $(\'[name=score]\').val();\r\n\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
#nullable restore
#line 75 "C:\dev\keylinx\KeylinxCodeTest\CSKeylinx\CSKeylinx\Views\Clans\Details.cshtml"
                 Write(Url.Action("Edit", "Clans"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data: { ""PlayerId"": playerId, ""PlayerScore"": playerScore },
                dataTyoe: ""json"",
                success: function (result) {
                    $(""#"" + playerId).html(playerScore);
                }

            });

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CSKeylinx.Models.Players>> Html { get; private set; }
    }
}
#pragma warning restore 1591
