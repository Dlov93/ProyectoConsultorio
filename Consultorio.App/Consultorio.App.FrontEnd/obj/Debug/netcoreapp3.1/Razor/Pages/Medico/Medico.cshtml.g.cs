<<<<<<< HEAD
#pragma checksum "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41fcf48741ef006c9a2fdc142eacb7b4397374d7"
=======
#pragma checksum "C:\Users\Diana\Desktop\clases\programacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa"
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Consultorio.App.FrontEnd.Pages.Medico.Pages_Medico_Medico), @"mvc.1.0.razor-page", @"/Pages/Medico/Medico.cshtml")]
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
#line 1 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\_ViewImports.cshtml"
using Consultorio.App.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
using Consultorio.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa", @"/Pages/Medico/Medico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932b505c31a826811756a8115dee8ee3c7ce4bac", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medico_Medico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Medico/CrearMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Medico/DetalleMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Medico/EditarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Medico/BorrarMedico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Listar Médicos</h1>\r\n");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fcf48741ef006c9a2fdc142eacb7b4397374d75306", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa4946", async() => {
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
                WriteLiteral("Agregar Médico");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
<table class="" table table-info table-bordered table-striped"" >
<tr>
    <th scope=""col"">Documento</th>
    <th scope=""col"">Nombre</th>
    <th scope=""col"">Apellido</th>
    <th scope=""col"">Telefono</th>
    <th scope=""col"">Genero</th>
    <th scope=""col"">Especialidad</th>
    <th scope=""col"">Codigo</th>
    <th scope=""col"">RegistroRethus</th>
    <th scope=""col"">Horario</th>

</tr>
");
#nullable restore
#line 21 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
 foreach(var medico in Model.medicos){

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.RegistroRethus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
   Write(medico.Horario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fcf48741ef006c9a2fdc142eacb7b4397374d710014", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa9504", async() => {
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-documento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
                                                                                         WriteLiteral(medico.Documento);

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
            WriteLiteral(" </td>\r\n    <td>");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fcf48741ef006c9a2fdc142eacb7b4397374d712413", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa11887", async() => {
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-documento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
                                                                                        WriteLiteral(medico.Documento);

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
            WriteLiteral(" </td>\r\n    <td>");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fcf48741ef006c9a2fdc142eacb7b4397374d714810", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17315bcbf2ef9e1ce8c821e1a6b7cd5120a3e0aa14269", async() => {
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-documento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
                                                                                        WriteLiteral(medico.Documento);

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
<<<<<<< HEAD
            WriteLiteral(" </td>\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41fcf48741ef006c9a2fdc142eacb7b4397374d717207", async() => {
                WriteLiteral("Actualizar Horario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-documento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
                                                                                        WriteLiteral(medico.Documento);

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
            WriteLiteral(" </td>\r\n    \r\n    \r\n</tr>\r\n");
=======
            WriteLiteral(" </td>\r\n   \r\n    \r\n    \r\n</tr>\r\n");
>>>>>>> 5b51a999d9b32458bb9e6200766ab91edb2c2bb7
#nullable restore
#line 39 "C:\Users\JUAN SEBASTIAN\Documents\ProyectoHospitalizacion\ProyectoConsultorio\Consultorio.App\Consultorio.App.FrontEnd\Pages\Medico\Medico.cshtml"
}    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.MedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.MedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.MedicoModel>)PageContext?.ViewData;
        public MyApp.Namespace.MedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
