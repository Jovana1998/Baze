#pragma checksum "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa42537c196281d1b86d292eb58452bf094eaae9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Baze_Teretane.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
namespace Baze_Teretane.Pages.Shared
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
#line 1 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\_ViewImports.cshtml"
using Baze_Teretane;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa42537c196281d1b86d292eb58452bf094eaae9", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9956a0e18673aca9bf81e4c2365f2c1fb17493", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa42537c196281d1b86d292eb58452bf094eaae93157", async() => {
                WriteLiteral(@"
    <title>Gym | Body Fitness</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""./vendor/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""./vendor/bootstrap/css/bootstrap-datetimepicker.css"">
    <link rel=""stylesheet"" href=""./css/style.css"">
    <link rel=""stylesheet"" href=""./css/responsive.css"">
    <link rel=""stylesheet"" href=""./vendor/owl.carousel/assets/owl.carousel.css"">
    <link rel=""stylesheet"" href=""./vendor/wow/animate.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""./vendor/gallery/gallery.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""./vendor/gallery/lightbox.min.css"" />

    <link href=""https://fonts.googleapis.com/css2?family=Source+Sans+Pro:ital,wght@0,200;0,300;0,400;0,600;0,700;0,900;1,200;1,300;1,400;1,600;1,700;1,900&display=swap"" rel=""stylesheet"">
    <link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet""");
                WriteLiteral(@">
    <script src=""./vendor/gallery/lightbox-plus-jquery.min.js""></script>
    <script src=""./vendor/jquery/jquery.min.js""></script>
    <script src=""./vendor/owl.carousel/owl.carousel.min.js""></script>
    <script src=""./vendor/wow/wow.min.js""></script>

    <script>
        new WOW().init();
        wow = new WOW(
            {
                boxClass: 'wow',      // default
                animateClass: 'animated', // default
                offset: 0,          // default
                mobile: true,       // default
                live: true        // default
            }
        )
        wow.init();
    </script>

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa42537c196281d1b86d292eb58452bf094eaae95890", async() => {
                WriteLiteral(@"
    <header class=""header-area"">
        <!-- Start Navbar Area -->
        <div class=""food-nav"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""header_menu_wrapper"">
                        <nav class=""navbar navbar-expand-md navbar-light"">
                            <a class=""navbar-brand"" href=""#"">
                                <img src=""./image/logo/logo.png"" alt=""logo"" class=""logolight"">
                                <img src=""./image/logo/logodark.png"" alt=""logo"" class=""logodark"">
                            </a>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <div id=""silder"" class=""silder_wrapper"">
        <div id=""home-silder"" class=""owl-carousel owl-theme"">
            <div class=""item"">
                <img src=""./image/gallery/4.jpg"" width=""100%"" alt=""silder images"" title=""silder images"">
            </div>
            <di");
                WriteLiteral("v class=\"item\">\r\n                <img src=\"./image/gallery/3.jpg\" width=\"100%\" alt=\"silder images\" title=\"silder images\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- silder End -->\r\n    ");
#nullable restore
#line 68 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- Footer Section -->
    <footer id=""footer"">
        <div class=""container-fluid"">
            <div class=""row wow fadeInUp"">
                <img src=""./image/logo/footerlogo.png"" alt=""footer_logo"" class=""img-responsive"">
                <p>Et aut eum quis fuga eos sunt ipsa nihil. Labore corporis magni eligendi fuga maxime saepe commodi placeat.</p>
                <div class=""social-links"">
                    <a href=""#"" class=""twitter""><i class=""fa fa-twitter""></i></a>
                    <a href=""#"" class=""facebook""><i class=""fa fa-facebook""></i></a>
                    <a href=""#"" class=""instagram""><i class=""fa fa-instagram""></i></a>
                    <a href=""#"" class=""google-plus""><i class=""fa fa-skype""></i></a>
                    <a href=""#"" class=""linkedin""><i class=""fa fa-linkedin""></i></a>
                </div>
                <div class=""footer_copyright"">
                    <p class=""wow fadeInDown animated"">Design By JVK Team- © Copyright 2021</p>
               ");
                WriteLiteral(@" </div>
            </div>
        </div>
    </footer>
    <!-- back-to-top scrtion -->
    <div class=""top_button"">
        <a class=""back-to-top"" style=""cursor:pointer;"" id=""top-scrolltop""><i class=""fa fa-angle-up""></i></a>
    </div>
    <!-- back-to-top scrtion End-->
    <!-- script files -->
    <!-- home silder -->

    <script>
        $(document).ready(function () {
            $('#home-silder').owlCarousel({
                items: 1,
                itemsDesktop: [1199, 1],
                itemsDesktopSmall: [992, 1],
                itemsTablet: [768, 1],
                itemsMobile: [450, 1],
                autoPlay: 10000,
                pagination: true,
                navigation: true,
                navigationText: ['<i class=""fa fa-angle-left""></i>', '<i class=""fa fa-angle-right""></i>']
            });
        });

        $(document).ready(function () {
            $('#testimonial').owlCarousel({
                items: 1,
                itemsDesktop: [1199");
                WriteLiteral(@", 1],
                itemsDesktopSmall: [992, 1],
                itemsTablet: [768, 1],
                itemsMobile: [450, 1],
                autoPlay: 10000,
                pagination: true,
                navigation: true,
                navigationText: ['<i class=""fa fa-angle-left""></i>', '<i class=""fa fa-angle-right""></i>']
            });
        });

        $(document).ready(function () {
            $('#trainer_team').owlCarousel({
                items: 4,
                itemsDesktop: [1199, 3],
                itemsDesktopSmall: [992, 3],
                itemsTablet: [768, 2],
                itemsMobile: [450, 1],
                autoPlay: 10000,
                pagination: false,
                navigation: true,
                navigationText: ['<i class=""fa fa-angle-left""></i>', '<i class=""fa fa-angle-right""></i>']
            });
        });

    </script>
    <script>
        $(function () {
            $('#datetimepicker1').datetimepicker();
        });
  ");
                WriteLiteral(@"  </script>
    <script src=""./vendor/bootstrap/js/moment.min.js""></script>
    <script src=""./vendor/bootstrap/js/bootstrap-datetimepicker.js""></script>
    <script src=""./vendor/bootstrap/js/bootstrap.min.js""></script>
    <script src=""./js/custom.js""></script>

    <!-- script files -->
");
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
            WriteLiteral("\r\n</html>\r\n");
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
