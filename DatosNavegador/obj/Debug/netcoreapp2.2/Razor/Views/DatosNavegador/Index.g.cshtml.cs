#pragma checksum "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6f73196b600f1058827065aef9907ed48fc25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatosNavegador_Index), @"mvc.1.0.view", @"/Views/DatosNavegador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatosNavegador/Index.cshtml", typeof(AspNetCore.Views_DatosNavegador_Index))]
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
#line 1 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\_ViewImports.cshtml"
using DatosNavegador;

#line default
#line hidden
#line 2 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\_ViewImports.cshtml"
using DatosNavegador.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6f73196b600f1058827065aef9907ed48fc25b", @"/Views/DatosNavegador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af089f2d96e545f9a8fd8fb01dc1f3b55d4767df", @"/Views/_ViewImports.cshtml")]
    public class Views_DatosNavegador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 64, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h2>Datos del Navegador</h2>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(108, 21, false);
#line 10 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.BrowserFamily);

#line default
#line hidden
            EndContext();
            BeginContext(129, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(145, 20, false);
#line 11 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.BrowserMajor);

#line default
#line hidden
            EndContext();
            BeginContext(165, 68, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<h2>Datos del Sistema Operativo</h2>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(234, 16, false);
#line 16 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.OSFamily);

#line default
#line hidden
            EndContext();
            BeginContext(250, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(266, 15, false);
#line 17 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.OSMajor);

#line default
#line hidden
            EndContext();
            BeginContext(281, 64, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n\r\n<h2>Datos del Dispositivo</h2>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(346, 20, false);
#line 23 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.DeviceFamily);

#line default
#line hidden
            EndContext();
            BeginContext(366, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(382, 19, false);
#line 24 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.DeviceModel);

#line default
#line hidden
            EndContext();
            BeginContext(401, 57, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<h2>IP de la maquina</h2>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(459, 10, false);
#line 29 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.IP);

#line default
#line hidden
            EndContext();
            BeginContext(469, 80, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<h2>Usuario que inicio sesion en la Maquina</h2>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(550, 14, false);
#line 34 "C:\Users\carlos.ozuna\source\repos\DatosNavegador\DatosNavegador\Views\DatosNavegador\Index.cshtml"
   Write(ViewBag.UserPC);

#line default
#line hidden
            EndContext();
            BeginContext(564, 12, true);
            WriteLiteral("</li>\r\n</ul>");
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