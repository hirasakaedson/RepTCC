#pragma checksum "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19b70f6774f58adac084b2a1b39fbd0412109cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_LoginPage___Copy), @"mvc.1.0.view", @"/Views/Usuario/LoginPage - Copy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19b70f6774f58adac084b2a1b39fbd0412109cdd", @"/Views/Usuario/LoginPage - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93030cd03e0ce389ef83fb9365b4a6fae6efa281", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_LoginPage___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sisgef.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
   ViewData["Title"] = "LoginPage";
    Layout = "~/Views/Shared/_Login.cshtml";
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    span {\r\n        color: red;\r\n        float: left;\r\n        margin-top: 1%;\r\n        margin-left: 1%;\r\n    }\r\n</style>\r\n\r\n<br>\r\n<center>\r\n    <h1>Login</h1>\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 21 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <fieldset style=\"width: 40%;\">\r\n                    <br />\r\n                    <input type=\"text\" class=\"form-control\" name=\"Login\" placeholder=\"Digite seu login...\" />\r\n                    ");
#nullable restore
#line 28 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
               Write(Html.ValidationMessageFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <br />\r\n                    <br />\r\n                    <input type=\"password\" class=\"form-control\" name=\"Senha\" placeholder=\"Digite sua senha...\" />\r\n                    ");
#nullable restore
#line 33 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
               Write(Html.ValidationMessageFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <br />
                    <br />
                    <br />
                    <button type=""submit"" class=""btn btn-primary"" style=""background-color: mediumseagreen; border: none;"">Logar</button>
                    <br /><br /><br />

");
#nullable restore
#line 40 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
                     if (ViewBag.Erro != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"padding: 20px; color: white; background-color: dimgray\">\r\n        ");
#nullable restore
#line 43 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
   Write(ViewBag.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>");
#nullable restore
#line 44 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </fieldset>");
#nullable restore
#line 45 "C:\Projetos\RepTCC\TCC\Sisgef\Views\Usuario\LoginPage - Copy.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sisgef.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
