#pragma checksum "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f0f62a9acdba1a8521e7764bf586ad09abb5639"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Consultorio.App.FrontEnd.Pages.Medico.Pages_Medico_DetalleMedico), @"mvc.1.0.razor-page", @"/Pages/Medico/DetalleMedico.cshtml")]
namespace Consultorio.App.FrontEnd.Pages.Medico
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
#line 1 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\_ViewImports.cshtml"
using Consultorio.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0f62a9acdba1a8521e7764bf586ad09abb5639", @"/Pages/Medico/DetalleMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b505c31a826811756a8115dee8ee3c7ce4bac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medico_DetalleMedico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle Médico</h1>\r\n\r\n<ul>\r\n    <li>Documento: ");
#nullable restore
#line 8 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
              Write(Model.medico.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Nombre: ");
#nullable restore
#line 9 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
           Write(Model.medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Apellido: ");
#nullable restore
#line 10 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
             Write(Model.medico.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Teléfono: ");
#nullable restore
#line 11 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
             Write(Model.medico.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Género: ");
#nullable restore
#line 12 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
           Write(Model.medico.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Especialidad:");
#nullable restore
#line 13 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
                Write(Model.medico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Código: ");
#nullable restore
#line 14 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
           Write(Model.medico.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Registro Rethus: ");
#nullable restore
#line 15 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
                    Write(Model.medico.RegistroRethus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Horario: ");
#nullable restore
#line 16 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\DetalleMedico.cshtml"
            Write(Model.medico.Horario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetalleMedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleMedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetalleMedicoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetalleMedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591