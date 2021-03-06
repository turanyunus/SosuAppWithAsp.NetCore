#pragma checksum "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26bc4104ba381f69dee1414f12f4ce8daaeeb1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Details), @"mvc.1.0.view", @"/Views/Post/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Details.cshtml", typeof(AspNetCore.Views_Post_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26bc4104ba381f69dee1414f12f4ce8daaeeb1e", @"/Views/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029f5e2d9e6424a3b90a680ebcf4ebec0f1ca715", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostDetailsModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post-reply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(69, 119, true);
            WriteLiteral("<header>\r\n    <!-- Page Header -->\r\n    <div id=\"post-header\" class=\"page-header\">\r\n        <div class=\"background-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 188, "\"", 248, 4);
            WriteAttributeValue("", 196, "background-image:", 196, 17, true);
            WriteAttributeValue(" ", 213, "url(\'/lib/img/", 214, 15, true);
#line 8 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
WriteAttributeValue("", 228, Model.Post.Image, 228, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 245, "\');", 245, 3, true);
            EndWriteAttribute();
            BeginContext(249, 235, true);
            WriteLiteral("></div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"post-meta\">\r\n                        <a class=\"post-category cat-2\" href=\"category.html\">");
            EndContext();
            BeginContext(485, 19, false);
#line 13 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                                                                       Write(Model.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(504, 54, true);
            WriteLiteral("</a>\r\n                        <span class=\"post-date\">");
            EndContext();
            BeginContext(559, 15, false);
#line 14 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                                           Write(Model.Post.Date);

#line default
#line hidden
            EndContext();
            BeginContext(574, 61, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <h1>");
            EndContext();
            BeginContext(636, 15, false);
#line 16 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                   Write(Model.Post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(651, 464, true);
            WriteLiteral(@"</h1>
                </div>
            </div>
        </div>
    </div>
    <!-- /Page Header -->
</header>
<!-- section -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- Post content -->
            <div class=""col-md-8"">
                <div class=""section-row sticky-container"">
                    <div class=""main-post"">
                        <h3>");
            EndContext();
            BeginContext(1116, 15, false);
#line 33 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                       Write(Model.Post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1166, 22, false);
#line 34 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                      Write(Model.Post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 1556, true);
            WriteLiteral(@"</p>
                    </div>
                    <div class=""post-shares sticky-shares"">
                        <a href=""#"" class=""share-facebook""><i class=""fa fa-facebook""></i></a>
                        <a href=""#"" class=""share-twitter""><i class=""fa fa-twitter""></i></a>
                        <a href=""#"" class=""share-google-plus""><i class=""fa fa-google-plus""></i></a>
                        <a href=""#"" class=""share-pinterest""><i class=""fa fa-pinterest""></i></a>
                        <a href=""#"" class=""share-linkedin""><i class=""fa fa-linkedin""></i></a>
                        <a href=""#""><i class=""fa fa-envelope""></i></a>
                    </div>
                </div>
                    
                <!-- ad -->
                <div class=""section-row text-center"">
                    <a href=""#"" style=""display: inline-block;margin: auto;"">
                        <img class=""img-responsive"" src=""./img/ad-2.jpg"" alt="""">
                    </a>
                </div>
        ");
            WriteLiteral(@"        <!-- ad -->
                <!-- author -->
                <div class=""section-row"">
                    <div class=""post-author"">
                        <div class=""media"">
                            <div class=""media-left"">
                                <img class=""media-object"" src=""./img/author.png"" alt="""">
                            </div>
                            <div class=""media-body"">
                                <div class=""media-heading"">
                                    <h3>Yazar : ");
            EndContext();
            BeginContext(2745, 17, false);
#line 62 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                                           Write(Model.Post.Author);

#line default
#line hidden
            EndContext();
            BeginContext(2762, 4581, true);
            WriteLiteral(@"</h3>
                                </div>
                                <p>Yazar Hakkında</p>
                                <ul class=""author-social"">
                                    <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-instagram""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /author -->
                <!-- comments -->
                <div class=""section-row"">
                    <div class=""section-title"">
                        <h2>Yorumlar</h2>
                    </div>

                    <div class=""post-comments"">
                        <!-- comment -->
   ");
            WriteLiteral(@"                     <div class=""media"">
                            <div class=""media-left"">
                                <img class=""media-object"" src=""./img/avatar.png"" alt="""">
                            </div>
                            <div class=""media-body"">
                                <div class=""media-heading"">
                                    <h4>John Doe</h4>
                                    <span class=""time"">March 27, 2018 at 8:00 am</span>
                                    <a href=""#"" class=""reply"">Reply</a>
                                </div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>

                                <!-- comment -->
                                <div class=""media"">
                                    <div class=""medi");
            WriteLiteral(@"a-left"">
                                        <img class=""media-object"" src=""./img/avatar.png"" alt="""">
                                    </div>
                                    <div class=""media-body"">
                                        <div class=""media-heading"">
                                            <h4>John Doe</h4>
                                            <span class=""time"">March 27, 2018 at 8:00 am</span>
                                            <a href=""#"" class=""reply"">Reply</a>
                                        </div>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                                    </div>
                                </div>
                                <!-- /comment -->
                            </div>
");
            WriteLiteral(@"                        </div>
                        <!-- /comment -->
                        <!-- comment -->
                        <div class=""media"">
                            <div class=""media-left"">
                                <img class=""media-object"" src=""./img/avatar.png"" alt="""">
                            </div>
                            <div class=""media-body"">
                                <div class=""media-heading"">
                                    <h4>John Doe</h4>
                                    <span class=""time"">March 27, 2018 at 8:00 am</span>
                                    <a href=""#"" class=""reply"">Reply</a>
                                </div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            </div>
 ");
            WriteLiteral(@"                       </div>
                        <!-- /comment -->
                    </div>
                </div>
                <!-- /comments -->
                <!-- reply -->
                <div class=""section-row"">
                    <div class=""section-title"">
                        <h2>Leave a reply</h2>
                        <p>your email address will not be published. required fields are marked *</p>
                    </div>
                    ");
            EndContext();
            BeginContext(7343, 1491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56120cae5f974a4a9cbbbe7005085feb", async() => {
                BeginContext(7368, 1459, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <span>Name *</span>
                                    <input class=""input"" type=""text"" name=""name"">
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <span>Email *</span>
                                    <input class=""input"" type=""email"" name=""email"">
                                </div>
                            </div>
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <span>Website</span>
                                    <input class=""input"" type=""text"" name=""website"">
                                </div>
                            </");
                WriteLiteral(@"div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <textarea class=""input"" name=""message"" placeholder=""Message""></textarea>
                                </div>
                                <button class=""primary-button"">Submit</button>
                            </div>
                        </div>
                    ");
                EndContext();
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
            EndContext();
            BeginContext(8834, 234, true);
            WriteLiteral("\r\n                </div>\r\n                <!-- /reply -->\r\n            </div>\r\n            <!-- /Post content -->\r\n            <!-- aside -->\r\n            <div class=\"col-md-4\">\r\n\r\n                <!-- catagories -->\r\n                ");
            EndContext();
            BeginContext(9069, 41, false);
#line 174 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
           Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
            EndContext();
            BeginContext(9110, 95, true);
            WriteLiteral("\r\n                <!-- /catagories -->\r\n                <!-- MostReadPost -->\r\n                ");
            EndContext();
            BeginContext(9206, 43, false);
#line 177 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
           Write(await Component.InvokeAsync("MostReadPost"));

#line default
#line hidden
            EndContext();
            BeginContext(9249, 97, true);
            WriteLiteral("\r\n                <!-- /MostReadPost -->\r\n                <!-- FeaturedPost -->\r\n                ");
            EndContext();
            BeginContext(9347, 43, false);
#line 180 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedPost"));

#line default
#line hidden
            EndContext();
            BeginContext(9390, 353, true);
            WriteLiteral(@"
                <!-- /FeaturedPost -->
                <!-- tags -->
                <div class=""aside-widget"">
                    <div class=""section-title"">
                        <h2 style=""border-bottom:1px solid #ccc;"">Etiketler</h2>
                    </div>
                    <div class=""tags-widget"">
                        <ul>
");
            EndContext();
#line 189 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                              
                                string[] tags = Model.Post.Tag.Split(',');
                                for (int i = 0; i < tags.Length; i++)
                                {

#line default
#line hidden
            BeginContext(9957, 53, true);
            WriteLiteral("                                    <li><a href=\"#\">#");
            EndContext();
            BeginContext(10011, 17, false);
#line 193 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                                                Write(Html.Raw(tags[i]));

#line default
#line hidden
            EndContext();
            BeginContext(10028, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 194 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Post\Details.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(10105, 271, true);
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
                <!-- /tags -->


            </div>
            <!-- /aside -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /section -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostDetailsModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
