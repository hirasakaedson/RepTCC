#pragma checksum "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5431b7ce4ca3d4751ec68e7b3bfb255c8ce766e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Lista), @"mvc.1.0.view", @"/Views/Veiculo/Lista.cshtml")]
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
#line 1 "C:\Projetos\RepTCC\TCC\Sisgef\Views\_ViewImports.cshtml"
using Sisgef;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\RepTCC\TCC\Sisgef\Views\_ViewImports.cshtml"
using Sisgef.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5431b7ce4ca3d4751ec68e7b3bfb255c8ce766e4", @"/Views/Veiculo/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93030cd03e0ce389ef83fb9365b4a6fae6efa281", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sisgef.Models.Veiculo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Veiculo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1 float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Você tem certeza que deseja deletar?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5431b7ce4ca3d4751ec68e7b3bfb255c8ce766e45779", async() => {
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
            WriteLiteral("\r\n<div class=\"container-fluid mt-4 \">\r\n    <div class=\"col-12\">\r\n        <h4>Veículos cadastrados</h4>\r\n        <hr />\r\n        <div class=\"row h5 text-left\">\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 13 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 16 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 19 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n\r\n        <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 25 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row font-weight-bold\" data-toggle=\"collapse\" data-target=\"#collapse");
#nullable restore
#line 27 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"\r\n                     aria-controls=\"collapseOne\">\r\n                    <div class=\"col-2 btn-link font-weight-bold\">\r\n                        ");
#nullable restore
#line 30 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-2 btn-link font-weight-bold\">\r\n                        ");
#nullable restore
#line 33 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-2 btn-link font-weight-bold\">\r\n                        ");
#nullable restore
#line 36 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5431b7ce4ca3d4751ec68e7b3bfb255c8ce766e49957", async() => {
                WriteLiteral(" Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5431b7ce4ca3d4751ec68e7b3bfb255c8ce766e412297", async() => {
                WriteLiteral("Excluir ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
            WriteLiteral("                <div");
            BeginWriteAttribute("id", " id=\"", 1950, "\"", 1973, 2);
            WriteAttributeValue("", 1955, "collapse", 1955, 8, true);
#nullable restore
#line 48 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
WriteAttributeValue("", 1963, item.Id, 1963, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse \" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\">\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 52 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Renavam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 53 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Renavam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 56 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 57 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 60 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.TipoCarroceria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 61 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.TipoCarroceria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 64 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.TipoDoVeiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 65 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.TipoDoVeiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 68 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Chassi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 69 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Chassi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"margin-top:10px\">\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 74 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.AnoFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 75 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.AnoFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 78 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Odometro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 79 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Odometro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 82 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Combustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 83 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Combustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"margin-top:10px\">\r\n                        <div class=\"col-4\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 88 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.NomeDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 89 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.NomeDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 92 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.CpfCnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 93 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.CpfCnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 96 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.LocalDeEmplacamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 97 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.LocalDeEmplacamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\" style=\"margin-top:10px\">\r\n                        <div class=\"col-4\">\r\n                            <a class=\"font-weight-bold\"> ");
#nullable restore
#line 102 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><br />\r\n                            ");
#nullable restore
#line 103 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
                       Write(Html.DisplayFor(model => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 107 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sisgef.Models.Veiculo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
