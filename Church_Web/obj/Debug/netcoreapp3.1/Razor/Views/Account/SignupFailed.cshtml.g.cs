#pragma checksum "C:\Users\DanielRockson\source\repos\Church_Web\Views\Account\SignupFailed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c91298aec2f93c1eb297c95eff955c4fb70b702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignupFailed), @"mvc.1.0.view", @"/Views/Account/SignupFailed.cshtml")]
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
#line 1 "C:\Users\DanielRockson\source\repos\Church_Web\Views\_ViewImports.cshtml"
using Church_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielRockson\source\repos\Church_Web\Views\_ViewImports.cshtml"
using Church_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c91298aec2f93c1eb297c95eff955c4fb70b702", @"/Views/Account/SignupFailed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e01006f745f37ac4e96bc7e80b2e1d41d40021a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignupFailed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main>
    <section class=""best-pricing best-pricing2 pricing-padding2"">
        <div style="" background-color: #fafafa !important;padding:20px !important;border-radius:30px; min-width: 130px"">
            <div class=""section-tittle text-center"">
                <h1><i class=""fa fa-check-square-o"" aria-hidden=""true"" style=""color:#4285F4""></i></h1>
                <h3> An Error Occured </h3>
                <h5> ");
#nullable restore
#line 7 "C:\Users\DanielRockson\source\repos\Church_Web\Views\Account\SignupFailed.cshtml"
                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
        </div>
    </section>
</main>
<style>
    body {
        height: 100vh;
        position: relative;
    }

    main {
        display: flex;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }

    div.best-pricing {
        padding: 0 !important;
    }
</style>");
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
