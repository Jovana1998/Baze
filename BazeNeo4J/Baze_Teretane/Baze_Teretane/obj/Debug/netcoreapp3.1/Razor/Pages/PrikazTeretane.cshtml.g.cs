#pragma checksum "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccac0c25c18f2efe14bd204b3d2fb31ace4d2a8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Baze_Teretane.Pages.Pages_PrikazTeretane), @"mvc.1.0.razor-page", @"/Pages/PrikazTeretane.cshtml")]
namespace Baze_Teretane.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccac0c25c18f2efe14bd204b3d2fb31ace4d2a8b", @"/Pages/PrikazTeretane.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9956a0e18673aca9bf81e4c2365f2c1fb17493", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PrikazTeretane : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
  
    ViewData["Title"] = "PrikazTeretane";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccac0c25c18f2efe14bd204b3d2fb31ace4d2a8b3630", async() => {
                WriteLiteral("\r\n    <div>Svi treneri </div>\r\n");
#nullable restore
#line 9 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
     foreach (Trener k in Model.SviTreneri)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>");
#nullable restore
#line 11 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
      Write(k.ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
      Write(k.prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 13 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
      Write(k.ocena);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>Sve usluge</div>\r\n");
#nullable restore
#line 17 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
     foreach (Usluga a in Model.SveUsluge)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>");
#nullable restore
#line 19 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
      Write(a.nazivusluge);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 20 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"
      Write(a.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 21 "C:\Users\Korisnik\Documents\NBP\Baze\BazeNeo4J\Baze_Teretane\Baze_Teretane\Pages\PrikazTeretane.cshtml"


    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Baze_Teretane.Pages.PrikazTeretaneModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Baze_Teretane.Pages.PrikazTeretaneModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Baze_Teretane.Pages.PrikazTeretaneModel>)PageContext?.ViewData;
        public Baze_Teretane.Pages.PrikazTeretaneModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591