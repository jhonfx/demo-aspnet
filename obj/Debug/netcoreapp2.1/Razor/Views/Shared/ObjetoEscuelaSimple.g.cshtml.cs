#pragma checksum "/Users/jpurataf/Projects/net/HolaMundoMVC/Views/Shared/ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8200b6777df49f75d935b43bfb6ca6058e8d2d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ObjetoEscuelaSimple.cshtml", typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple))]
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
#line 1 "/Users/jpurataf/Projects/net/HolaMundoMVC/Views/_ViewImports.cshtml"
using HolaMundoMVC;

#line default
#line hidden
#line 2 "/Users/jpurataf/Projects/net/HolaMundoMVC/Views/_ViewImports.cshtml"
using HolaMundoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8200b6777df49f75d935b43bfb6ca6058e8d2d9e", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844b5729bef53cbee2b226a2f3054d035bc852", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 19, true);
            WriteLiteral("\r\n<p>\r\n    Nombre: ");
            EndContext();
            BeginContext(46, 12, false);
#line 4 "/Users/jpurataf/Projects/net/HolaMundoMVC/Views/Shared/ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(58, 10, true);
            WriteLiteral("\r\n    Id: ");
            EndContext();
            BeginContext(69, 14, false);
#line 5 "/Users/jpurataf/Projects/net/HolaMundoMVC/Views/Shared/ObjetoEscuelaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(83, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
