#pragma checksum "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3967d368a6fcdca3f6815a7456114f5f45dab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3967d368a6fcdca3f6815a7456114f5f45dab5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029f5e2d9e6424a3b90a680ebcf4ebec0f1ca715", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HomeModels>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(66, 106, true);
            WriteLiteral("\r\n<!-- section -->\r\n<div class=\"section\">\r\n    <!-- container -->\r\n    <div class=\"container\">\r\n\r\n        ");
            EndContext();
            BeginContext(173, 43, false);
#line 11 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("FrontTopPost"));

#line default
#line hidden
            EndContext();
            BeginContext(216, 265, true);
            WriteLiteral(@";

        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-title"">
                    <h2 style=""border-bottom:1px solid #ccc;"">Son Eklenenler</h2>
                </div>
            </div>

");
            EndContext();
#line 21 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(538, 135, true);
            WriteLiteral("                <!-- post -->\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"post\">\r\n                        ");
            EndContext();
            BeginContext(673, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2acf90046e04a7eb2f359f49cdbebe8", async() => {
                BeginContext(766, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 770, "\"", 798, 2);
                WriteAttributeValue("", 776, "./img/", 776, 6, true);
#line 26 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 782, item.Post.Image, 782, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(799, 8, true);
                WriteLiteral(" alt=\"\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                                                         WriteLiteral(item.Post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(811, 136, true);
            WriteLiteral("\r\n                        <div class=\"post-body\">\r\n                            <div class=\"post-meta\">\r\n                                ");
            EndContext();
            BeginContext(947, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f5ece4357254da280946196771b2282", async() => {
                BeginContext(1067, 18, false);
#line 29 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                                                                                                                  Write(item.Category.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                                                WriteLiteral(item.Post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1029, "post-category", 1029, 13, true);
            AddHtmlAttributeValue(" ", 1042, "cat-", 1043, 5, true);
#line 29 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1047, item.Category.Id, 1047, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1089, 65, true);
            WriteLiteral("\r\n                                <a class=\"post-category cat-4\">");
            EndContext();
            BeginContext(1155, 14, false);
#line 30 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                          Write(item.Post.Like);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 69, true);
            WriteLiteral("</a>\r\n                                <a class=\"post-category cat-4\">");
            EndContext();
            BeginContext(1239, 17, false);
#line 31 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                          Write(item.Post.DisLike);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 62, true);
            WriteLiteral("</a>\r\n                                <span class=\"post-date\">");
            EndContext();
            BeginContext(1319, 14, false);
#line 32 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                   Write(item.Post.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 96, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                            <h3 class=\"post-title\">");
            EndContext();
            BeginContext(1429, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc5c4054a213433a9f7475bd7ec44338", async() => {
                BeginContext(1505, 14, false);
#line 34 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Post.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
                                                                                                   WriteLiteral(item.Post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1523, 123, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- /post -->\r\n");
            EndContext();
#line 39 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1661, 208, true);
            WriteLiteral("\r\n            <div class=\"clearfix visible-md visible-lg\"></div>\r\n        </div>\r\n        <!-- /row -->\r\n\r\n        <!-- row -->\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(1870, 43, false);
#line 48 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("AllMixedPost"));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 77, true);
            WriteLiteral(";\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(1991, 43, false);
#line 52 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("MostReadPost"));

#line default
#line hidden
            EndContext();
            BeginContext(2034, 21, true);
            WriteLiteral(";\r\n\r\n                ");
            EndContext();
            BeginContext(2056, 43, false);
#line 54 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("FeaturedPost"));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 128, true);
            WriteLiteral(";\r\n            </div>\r\n        </div>\r\n        <!-- /row -->\r\n\r\n    </div>\r\n    <!-- /container -->\r\n</div>\r\n<!-- /section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HomeModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591