#pragma checksum "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9773a2da814f525ac569c19c4307219434ae45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9773a2da814f525ac569c19c4307219434ae45", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029f5e2d9e6424a3b90a680ebcf4ebec0f1ca715", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/font-awesome/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 643, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "198ad553ec0140e08705fd44f492043e", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 14, true);
                WriteLiteral("</title>\r\n    ");
                EndContext();
                BeginContext(133, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d55046c9e7d74257ab39b2539bee3992", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(212, 165, true);
                WriteLiteral("\r\n    <!-- Google font -->\r\n    <link href=\"https://fonts.googleapis.com/css?family=Nunito+Sans:700%7CNunito:300,600\" rel=\"stylesheet\">\r\n    <!-- Bootstrap -->\r\n    ");
                EndContext();
                BeginContext(377, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "232983ba76d146db97bee124a2d91a58", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(453, 38, true);
                WriteLiteral("\r\n    <!-- Font Awesome Icon -->\r\n    ");
                EndContext();
                BeginContext(491, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88a6c86d6aec4d648bef4bd0206cf107", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(552, 39, true);
                WriteLiteral("\r\n    <!-- Custom stlylesheet -->\r\n    ");
                EndContext();
                BeginContext(591, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ecaa83017564cedafcb6c8494e4e184", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(659, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(670, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(672, 7853, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb005118fb3241e295920dd287f02814", async() => {
                BeginContext(678, 1073, true);
                WriteLiteral(@"
    <!-- Header -->
    <header id=""header"">
        <!-- Nav -->
        <div id=""nav"">
            <!-- Main Nav -->
            <div id=""nav-fixed"">
                <div class=""container"">
                    <!-- logo -->
                    <div class=""nav-logo"">
                        <a href=""/Home"" class=""logo""><img src=""./img/logo.png"" alt=""""></a>
                    </div>
                    <!-- /logo -->
                    <!-- nav -->
                    <ul class=""nav-menu nav navbar-nav"">
                        <li><a href=""/Home"">Anasayfa</a></li>
                        <li class=""cat-4""><a href=""/Post/Populer"">Popular</a></li>
                        <li class=""cat-1""><a href=""/Post/Books"">Kitap</a></li>
                        <li class=""cat-2""><a href=""/Post/TvSeries"">Dizi</a></li>
                        <li class=""cat-3""><a href=""/Post/Flim"">Film</a></li>
                    </ul>
                    <!-- /nav -->
                    <!-- search & aside toggle ");
                WriteLiteral("-->\r\n                    <div class=\"nav-btns\">\r\n");
                EndContext();
#line 42 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
                BeginContext(1839, 34, true);
                WriteLiteral("                            <span>");
                EndContext();
                BeginContext(1874, 18, false);
#line 44 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                             Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1892, 107, true);
                WriteLiteral("</span>\r\n                            <a style=\"text-decoration:none;\" href=\"/Admin/Index\"> Paneliniz </a>\r\n");
                EndContext();
#line 46 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2083, 228, true);
                WriteLiteral("                            <a style=\"text-decoration:none;\" href=\"/Account/Login/\">    Giriş Yapınız /     </a>\r\n                            <a style=\"text-decoration:none;\" href=\"/Account/Register/\"> Kayıt Olunuz        </a>\r\n");
                EndContext();
#line 51 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(2338, 1164, true);
                WriteLiteral(@"
                        <button class=""aside-btn""><i class=""fa fa-bars""></i></button>
                        <button class=""search-btn""><i class=""fa fa-search""></i></button>
                        <div class=""search-form"">
                            <input class=""search-input"" type=""text"" name=""search"" placeholder=""Enter Your Search ..."">
                            <button class=""search-close""><i class=""fa fa-times""></i></button>
                        </div>
                    </div>
                    <!-- /search & aside toggle -->
                </div>
            </div>
            <!-- /Main Nav -->
            <!-- Aside Nav -->
            <div id=""nav-aside"">
                <!-- nav -->
                <div class=""section-row"">
                    <ul class=""nav-aside-menu"">
                        <li><a href=""#"">Anaysafa</a></li>
                        <li><a href=""#"">Popular</a></li>
                        <li><a href=""#"">Kitap</a></li>
                        <li><");
                WriteLiteral("a href=\"#\">Dizi</a></li>\r\n                        <li><a href=\"#\">Film</a></li>\r\n                        <li><a href=\"#\">İletişim</a></li>\r\n");
                EndContext();
#line 75 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
                BeginContext(3590, 78, true);
                WriteLiteral("                            <li><a href=\"/Account/Logout\">Çıkış Yap</a></li>\r\n");
                EndContext();
#line 78 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(3752, 160, true);
                WriteLiteral("                            <li><a href=\"/Account/Register/\">Bize Katıl</a></li>\r\n                            <li><a href=\"/Account/Login/\">Giriş Yap</a></li>\r\n");
                EndContext();
#line 83 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(3939, 425, true);
                WriteLiteral(@"                    </ul>
                </div>
                <!-- /nav -->
                <!-- aside nav close -->
                <button class=""nav-aside-close""><i class=""fa fa-times""></i></button>
                <!-- /aside nav close -->
            </div>
            <!-- Aside Nav -->
        </div>
        <!-- /Nav -->
    </header>
    <!-- /Header -->

    <div class=""container mt-3"">
        ");
                EndContext();
                BeginContext(4365, 12, false);
#line 98 "D:\VsProjects\SuggestToSocialApp\SuggestToSocialApp.WebUI\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4377, 3067, true);
                WriteLiteral(@"
    </div>

    <!-- Footer -->
    <footer id=""footer"">
        <!-- container -->
        <div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-md-5"">
                    <div class=""footer-widget"">
                        <div class=""footer-logo"">
                            <a href=""index.html"" class=""logo""><img src=""./img/logo.png"" alt=""""></a>
                        </div>
                        <ul class=""footer-nav"">
                            <li><a href=""#"">Privacy Policy</a></li>
                            <li><a href=""#"">Advertisement</a></li>
                        </ul>
                        <div class=""footer-copyright"">
                            <span>
                                &copy; <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                                Copyright &copy;
                                <script>document.write(new Date().getFullYear());</s");
                WriteLiteral(@"cript> All rights reserved | This template is made with <i class=""fa fa-heart-o"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            </span>
                        </div>
                    </div>
                </div>

                <div class=""col-md-4"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""footer-widget"">
                                <h3 class=""footer-title"">About Us</h3>
                                <ul class=""footer-links"">
                                    <li><a href=""about.html"">About Us</a></li>
                                    <li><a href=""#"">Join Us</a></li>
                                    <li><a href=""contact.html"">Contacts</a></li>
                                </ul>
                          ");
                WriteLiteral(@"  </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""footer-widget"">
                                <h3 class=""footer-title"">Catagories</h3>
                                <ul class=""footer-links"">
                                    <li><a href=""category.html"">Web Design</a></li>
                                    <li><a href=""category.html"">JavaScript</a></li>
                                    <li><a href=""category.html"">Css</a></li>
                                    <li><a href=""category.html"">Jquery</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <div class=""footer-widget"">
                        <h3 class=""footer-title"">Join our Newsletter</h3>
                        <div class=""footer-newsletter"">
                            ");
                EndContext();
                BeginContext(7444, 267, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "412beef759b747839bf7c8d5b47ff5f3", async() => {
                    BeginContext(7450, 254, true);
                    WriteLiteral("\r\n                                <input class=\"input\" type=\"email\" name=\"newsletter\" placeholder=\"Enter your email\">\r\n                                <button class=\"newsletter-btn\"><i class=\"fa fa-paper-plane\"></i></button>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7711, 807, true);
                WriteLiteral(@"
                        </div>
                        <ul class=""footer-social"">
                            <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-pinterest""></i></a></li>
                        </ul>
                    </div>
                </div>

            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </footer>
    <!-- /Footer -->
    <!-- jQuery Plugins -->
    <script src=""js/jquery.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8525, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
