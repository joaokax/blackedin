#pragma checksum "C:\Users\Lucas\Source\Repos\Blackedin\BlackedinSite\Views\Home\MatchProfissional.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d724c7c41ce265155bd470ca6accb88c77ab141d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MatchProfissional), @"mvc.1.0.view", @"/Views/Home/MatchProfissional.cshtml")]
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
#line 1 "C:\Users\Lucas\Source\Repos\Blackedin\BlackedinSite\Views\_ViewImports.cshtml"
using BlackedinSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Source\Repos\Blackedin\BlackedinSite\Views\_ViewImports.cshtml"
using BlackedinSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d724c7c41ce265155bd470ca6accb88c77ab141d", @"/Views/Home/MatchProfissional.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdad379a1ecb611f07eaf224e77e30390754d66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MatchProfissional : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lucas\Source\Repos\Blackedin\BlackedinSite\Views\Home\MatchProfissional.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Lucas\Source\Repos\Blackedin\BlackedinSite\Views\Home\MatchProfissional.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<main class=""d-flex"">
    <aside id=""match-aside"" class=""ml-4 mt-4"">
        <h1 id=""match-h1"">Filtros</h1>

        <label id=""match-label"" class=""d-block"">Cargo desejado</label>
        <input id=""match-input-1"" type=""text"">

        <label id=""match-label"" class=""d-block"">Modelo de trabalho</label>

        <div id=""match-div"" class=""form-check"">
            <input class=""form-check-input"" type=""radio"" id=""formCheck-1"">
            <label class=""form-check-label"" for=""formCheck-1"">Presencial</label>
        </div>

        <div id=""match-div"" class=""form-check"" style=""margin-left: 15px;"">
            <input class=""form-check-input"" type=""radio"" id=""formCheck-2"">
            <label class=""form-check-label"" for=""formCheck-2"">Remoto</label>
        </div>

        <div id=""match-div"" class=""form-check"">
            <input class=""form-check-input"" type=""radio"" id=""formCheck-3"">
            <label class=""form-check-label"" for=""formCheck-3"">Hibrido</label>
        </div>

      ");
            WriteLiteral(@"  <label id=""match-label"" class=""d-block"" style=""margin-left: 15px;color: #888888;"">Distância</label>
        <input type=""range"" style=""margin-left: 15px;background: var(--blue);width: 220px;"">

        <label id=""match-label"" class=""d-block"">Faixa salarial</label>
        <div class=""dropdown"">

            <button id=""match-btn"" class=""btn btn-primary dropdown-toggle"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Selecione</button>
            <div class=""dropdown-menu"">
                <a class=""dropdown-item"" href=""#"">Até R$2.000</a>
                <a class=""dropdown-item"" href=""#"">Second Item</a>
                <a class=""dropdown-item"" href=""#"">Third Item</a>
            </div>
        </div>

        <label id=""match-label"" class=""d-block"">Tipo de deficiência</label>
        <div class=""dropdown"">
            <button id=""match-btn"" class=""btn btn-primary dropdown-toggle"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Selecione</button>
            <div class=");
            WriteLiteral(@"""dropdown-menu"">
                <a class=""dropdown-item"" href=""#"">First Item</a>
                <a class=""dropdown-item"" href=""#"">Second Item</a>
                <a class=""dropdown-item"" href=""#"">Third Item</a>
            </div>
        </div>

        <label id=""match-label"" class=""d-block"">Tipo de contrato</label>
        <div class=""dropdown"">
            <button id=""match-btn"" class=""btn btn-primary dropdown-toggle"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Selecione</button>
            <div class=""dropdown-menu"">
                <a class=""dropdown-item"" href=""#"">First Item</a>
                <a class=""dropdown-item"" href=""#"">Second Item</a>
                <a class=""dropdown-item"" href=""#"">Third Item</a>
            </div>
        </div>
    </aside>

    <div class=""container"">
        <div class=""row"">
            <div id=""empresa-img"" class=""col-md-12 mt-1 d-flex align-items-end justify-content-center"">
                <div id=""buttons"" class=""d-flex align-it");
            WriteLiteral(@"ems-baseline mb-2"">
                    <div id=""x"" class=""all-btn"">
                        <a href=""#""><i class=""fas fa-times""></i></a>
                    </div>
                    <div id=""heart"" class=""all-btn"">
                        <a href=""#""><i class=""fas fa-heart""></i></a>
                    </div>
                    <div id=""star"" class=""all-btn"">
                        <a href=""#""><i class=""fas fa-star""></i></a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div id=""match-div-2"" class=""col-md-12"">
                <h1 id=""match-h1-2"">Itaú</h1>
                <p>Desenvolvedor full-stack jr</p>
                <p id=""match-p"">Sobre a vaga:</p>
                <p>Desenvolver códigos elegantes, estáveis, <br>confiáveis e, não menos importante, fáceis de manter. Queremos código <br>limpo e que funcione bem, Desenvolver códigos e soluções sempre pensando<br> em eficiência, escalabilidade e estabilidade.");
            WriteLiteral("<br></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
