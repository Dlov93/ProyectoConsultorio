#pragma checksum "C:\c#\ProyectoConsultorio\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Horario\DetalleHorario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a0a163b9059637d00c8181cabdda0813fa0e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Consultorio.App.FrontEnd.Pages.Horario.Pages_Horario_DetalleHorario), @"mvc.1.0.razor-page", @"/Pages/Horario/DetalleHorario.cshtml")]
namespace Consultorio.App.FrontEnd.Pages.Horario
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
#line 1 "C:\c#\ProyectoConsultorio\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\_ViewImports.cshtml"
using Consultorio.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74a0a163b9059637d00c8181cabdda0813fa0e95", @"/Pages/Horario/DetalleHorario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b505c31a826811756a8115dee8ee3c7ce4bac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Horario_DetalleHorario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle Horario</h1>\r\n\r\n<ul>\r\n    <li>NameH: ");
#nullable restore
#line 8 "C:\c#\ProyectoConsultorio\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Horario\DetalleHorario.cshtml"
          Write(Model.horario.NameH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>FechaDisponible: ");
#nullable restore
#line 9 "C:\c#\ProyectoConsultorio\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Horario\DetalleHorario.cshtml"
                    Write(Model.horario.FechaDisponible);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetalleHorarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleHorarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleHorarioModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetalleHorarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
