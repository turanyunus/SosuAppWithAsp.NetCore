#pragma checksum "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81dca613057e512fcbacd7cce543b377ac184079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Categories/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Categories_Default))]
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
#line 1 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\_ViewImports.cshtml"
using SuggestToSocialApp.WebUI.Entity;

#line default
#line hidden
#line 2 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\_ViewImports.cshtml"
using SuggestToSocialApp.WebUI.Models;

#line default
#line hidden
#line 3 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\_ViewImports.cshtml"
using SuggestToSocialApp.WebUI.IdentityCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81dca613057e512fcbacd7cce543b377ac184079", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029f5e2d9e6424a3b90a680ebcf4ebec0f1ca715", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 274, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""aside-widget"">
        <div class=""section-title"">
            <h2 style=""border-bottom:1px solid #ccc;"">Kategoriler</h2>
        </div>
        <div class=""category-widget"">
            <ul>
                <!--     categories -->
");
            EndContext();
#line 10 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\Components\Categories\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(369, 35, true);
            WriteLiteral("                    <li><a href=\"#\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 404, "\"", 424, 2);
            WriteAttributeValue("", 412, "cat-", 412, 4, true);
#line 12 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 416, item.Id, 416, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(427, 9, false);
#line 12 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\Components\Categories\Default.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(436, 27, true);
            WriteLiteral("<span>111</span></a></li>\r\n");
            EndContext();
#line 13 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\Components\Categories\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(482, 83, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    <!-- /categories -->\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591