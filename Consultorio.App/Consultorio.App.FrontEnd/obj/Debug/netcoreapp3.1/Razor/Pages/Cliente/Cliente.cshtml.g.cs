#pragma checksum "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b90ff10a39b70c10b3b681e2137e83458d12499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Consultorio.App.FrontEnd.Pages.Cliente.Pages_Cliente_Cliente), @"mvc.1.0.razor-page", @"/Pages/Cliente/Cliente.cshtml")]
namespace Consultorio.App.FrontEnd.Pages.Cliente
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b90ff10a39b70c10b3b681e2137e83458d12499", @"/Pages/Cliente/Cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b505c31a826811756a8115dee8ee3c7ce4bac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cliente_Cliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Cliente/DetalleCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listar Clientes</h1>
<table class="" table table-info table-bordered table-striped"" >
<tr>
    <th scope=""col"">Documento</th>
    <th scope=""col"">Nombre</th>
    <th scope=""col"">Apellido</th>
    <th scope=""col"">FechaNacimiento</th>
    <th scope=""col"">Ciudad</th>
    <th scope=""col"">Correo</th>
    <th scope=""col"">Direccion</th>
    <th scope=""col"">Telefono</th>
    <th scope=""col"">Genero</th>
    <th scope=""col"">Acciones</th>
</tr>
");
#nullable restore
#line 19 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
 foreach(var cliente in Model.clientes){

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
   Write(cliente.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b90ff10a39b70c10b3b681e2137e83458d124997147", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-documento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
                                                                                           WriteLiteral(cliente.Documento);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["documento"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-documento", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["documento"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Cliente\Cliente.cshtml"
}    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ClienteModel>)PageContext?.ViewData;
        public MyApp.Namespace.ClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591