#pragma checksum "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8fb70a38e823942a5ca4440b7393692c1e6abb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YummyCookbook_View), @"mvc.1.0.view", @"/Views/YummyCookbook/View.cshtml")]
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
#line 1 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8fb70a38e823942a5ca4440b7393692c1e6abb7", @"/Views/YummyCookbook/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_YummyCookbook_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Recipe>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
  
    ViewData["Title"] = "Yummy Cookbook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8fb70a38e823942a5ca4440b7393692c1e6abb73443", async() => {
                WriteLiteral("\r\n    <style>\r\n        th { background-color: #009999; }\r\n        td { background-color: powderblue; }\r\n        table, th, td { border: 1px solid; }\r\n        table { border-collapse: collapse; }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h2>Recipe details</h2>\r\n\r\n");
#nullable restore
#line 20 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
 if ((bool)@ViewData["isCorrectId"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Difficulty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfLikes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Ingredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Process));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
           Write(Html.DisplayNameFor(model => model.TipsAndTricks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Difficulty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.NumberOfLikes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Ingredients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.Process));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
               Write(Html.DisplayFor(model => model.TipsAndTricks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n    </tbody>\r\n    </table>\r\n");
#nullable restore
#line 80 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Id of recipe is wrong</h3>\r\n");
#nullable restore
#line 84 "F:\Studia\1SemSE\tsd_aspnet\cookBookV5\WebApplication1\Views\YummyCookbook\View.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Recipe> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
