#pragma checksum "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff702ad6ebc4a0ae05df49f1f42d968f356eafc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veiculo_Lista___Copy___Copy), @"mvc.1.0.view", @"/Views/Veiculo/Lista - Copy - Copy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff702ad6ebc4a0ae05df49f1f42d968f356eafc", @"/Views/Veiculo/Lista - Copy - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93030cd03e0ce389ef83fb9365b4a6fae6efa281", @"/Views/_ViewImports.cshtml")]
    public class Views_Veiculo_Lista___Copy___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sisgef.Models.Veiculo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Você tem certeza que deseja deletar?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid mt-4 \">\r\n    <h4>Veículos cadastrados</h4>\r\n\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Renavam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Chassi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoDoVeiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.TipoCarroceria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.AnoFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Odometro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 48 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Combustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 51 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.NomeDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 54 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.DocumentoDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 57 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.LocalDeEmplacamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 60 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 68 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Renavam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Chassi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TipoDoVeiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TipoCarroceria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AnoFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 99 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Odometro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 102 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Combustivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 105 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NomeDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DocumentoDoProprietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 111 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LocalDeEmplacamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 114 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff702ad6ebc4a0ae05df49f1f42d968f356eafc15887", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
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
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff702ad6ebc4a0ae05df49f1f42d968f356eafc18074", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 121 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Veiculo\Lista - Copy - Copy.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
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
