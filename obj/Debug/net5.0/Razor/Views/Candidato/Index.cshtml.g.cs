#pragma checksum "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d640e8bd0f5d44628ba63c980eafba11b6137653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidato_Index), @"mvc.1.0.view", @"/Views/Candidato/Index.cshtml")]
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
#line 1 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\_ViewImports.cshtml"
using Aplicação_mvc_Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\_ViewImports.cshtml"
using Aplicação_mvc_Principal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d640e8bd0f5d44628ba63c980eafba11b6137653", @"/Views/Candidato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4022be919055aeccfc45920dbb99ea79cef45b4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formularioCandidato"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
  
    ViewData["Title"] = "Documentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b61376534194", async() => {
                WriteLiteral(@"

  
  <div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""cpf"">CPF</label>
      <input type=""text"" class=""form-control"" id=""cpf"" placeholder=""000.000.000-00"" onblur=buscaCpf()>
    </div>


    <div class=""form-group col-md-4"">
      <label for=""rg"">Identidade</label>
      <input type=""text"" class=""form-control"" id=""rg"" placeholder=""9654725"">
    </div>
    
    <div class=""form-group col-md-2"">
     <label for=""veiculo"">Possui Veículo</label>
      <input type=""text"" class=""form-control"" id=""veiculo"" placeholder=""Carro"">

    </div><div class=""form-group col-md-2"">
     <label for=""habilitacao"">Tipo da Habilitação</label>
      <select class=""form-control"" id=""habilitacao"" >
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b61376535216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b61376536189", async() => {
                    WriteLiteral("carteira a");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b61376537211", async() => {
                    WriteLiteral("carteira b");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b61376538233", async() => {
                    WriteLiteral("carteira ab");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      </select>
    </div>
    
  </div>
  
    <h1></h1>
    <h1></h1>
    <h1></h1>
    <h1></h1>
  <h1> Dados Pessoais</h1>

  <div class=""form-row"">
    <div class=""form-group col-md-7"">
      <label for=""nome"">Nome Completo</label>
      <input type=""text"" class=""form-control"" id=""nome"" placeholder=""Andre Carlos Souza e Silva"">
      <small class=""form-tex text-muted"">* Campo obrigadotrio. </small>
    </div>

    <div class=""form-group col-md-5"">
      <label for=""vaga"">Vaga Selecionada</label>
      <input type=""text"" class=""form-control"" id=""vaga"">      
    </div> 

  </div>

    


  <div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""dataNascimento"">Data de nascimento</label>
      <input type=""text"" class=""form-control"" id=""dataNascimento"" placeholder=""__/__/____"">
    </div>

     <div class=""form-group col-md-4"">
      <label for=""estadoCivil"">Estado Civil</label>
      <input type=""text"" class=""form-control"" id=""estadoCivil"" placeholder=""Casado"">
    </div>

    <div");
                WriteLiteral(" class=\"form-group col-md-4\">\n      <label for=\"sexo\">Sexo</label>\n      <select class=\"form-control\" id=\"sexo\" >\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b613765310493", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b613765311469", async() => {
                    WriteLiteral("masculino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d640e8bd0f5d44628ba63c980eafba11b613765312493", async() => {
                    WriteLiteral("feminino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      </select >
    </div>




  </div>


<h1></h1>
<h1></h1>
<h1></h1>
<h1></h1>

<h1> Endereço</h1>

  <div class=""form-row"">
    <div class=""form-group col-md-2"">
      <label for=""cep"">CEP</label>
      <input type=""text"" class=""form-control"" id=""cep"" onblur=buscaCep()>
    </div>

  </div>

 

<div class=""form-row"">
   <div class=""form-group col-md-7"">
    <label for=""endereco"">Endereço</label>
    <input type=""text"" class=""form-control"" id=""endereco"" placeholder=""Rua paraiso"">
  </div>

  <div class=""form-group col-md-2"">
    <label for=""numero"">Numero</label>
    <input type=""text"" class=""form-control"" id=""numero"" placeholder=""101"">
  </div>

  <div class=""form-group col-md-3"">
    <label for=""complemento"">Complemento</label>
    <input type=""text"" class=""form-control"" id=""complemento"" placeholder=""Apt, Sala"">
  </div>

</div>

  <div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""bairro"">Bairro</label>
      <input type=""text"" class=""form-control"" id=""bairro"" placeholder=""");
                WriteLiteral(@"Centro"">
    </div>

    <div class=""form-group col-md-6"">
      <label for=""cidade"">Cidade</label>
      <input type=""text"" class=""form-control"" id=""cidade"" placeholder=""Belo Horizonte"">
    </div>

    <div class=""form-group col-md-2"">
     <label for=""estado"">Estado</label>
      <select class=""form-control"" id=""estado"">
        </select>
    </div>
    
  </div>

  <h1></h1>
<h1></h1>
<h1></h1>
<h1></h1>

<h1> Contatos</h1>

<div class=""form-row"">
    <div class=""form-group col-md-3"">
      <label for=""telCelular"">Telefone Celular</label>
      <input type=""text"" class=""form-control"" id=""telCelular"">
    </div>


    <div class=""form-group col-md-3"">
      <label for=""telFixo"">Telefone Fixo</label>
      <input type=""text"" class=""form-control"" id=""telFixo"" >
    </div>
    
    <div class=""form-group col-md-6"">
      <label for=""email"">Email</label>
      <input type=""email"" class=""form-control"" id=""email"" placeholder=""exemplo@gmail.com"">
    </div>
    
  </div>



  
  <button type=""submit "" class=""btn ");
                WriteLiteral("btn-primary\">Cadastrar</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
  let formulario=document.getElementById(""formularioCandidato"");
  // pegar todos inputs
  let inputs = formulario.getElementsByTagName('input');
  // transformar HTMLCollection em array
  let inputsArray = [...inputs];
  function geraUf()
  {
    let estado =["""",""ac"",""al"",""ap"",""am"",""ba"",""ce"",""df"",""es"",""go"",""ma"",""mt"",""ms"",""mg"",""pa"",""pb"",""pr"",""pe"",""pi"",""rr"",""ro"",""rj"",""rn"",
                ""rs"",""sc"",""sp"",""se"",""to""];
    console.log(sexo);
    let html=""""
    for(let i=0;i<estado.length;i++)
    {
      html+=`
        <option>${estado[i]}</option>
      
      `
    }
    document.getElementById(""estado"").innerHTML=html;
  }
  function buscaCep ()
  {
    let temp = document.getElementById(""cep"").value;
    temp = temp.replace(""."","""");
    let stringConexao=`https://viacep.com.br/ws/${temp}/json/`;
      fetch(stringConexao).then( async function (response) {
        let cep = await response.json();
        console.log(cep.uf);
        document.getElementById(""estado"").value = cep.uf.toLowerCase();
 ");
            WriteLiteral(@"       document.getElementById(""cidade"").value =cep.localidade;
        document.getElementById(""endereco"").value  =cep.logradouro;
        document.getElementById(""bairro"").value  =cep.bairro;
      	// The API call was successful!
      	//return cep
      }).catch(function (err) {
      	// There was an error
      	console.warn('Something went wrong.', err);
      });
  }
  function buscaCpf()
  {
    //local da api
      let stringConexao=""https://localhost:5001/candidatos"";
      let endereco =  fetch(stringConexao).then( async function (response) {
      let candidato = await response.json();
      console.log(candidato);
       
      for(let i=0;i<candidato.length;i++)
      {
        //verifica se o cpf ja existe no banco de dados
        if(document.getElementById(""cpf"").value===candidato[i].cpf)
        {
          document.getElementById(""rg"").value =candidato[i].rg ;
          document.getElementById(""veiculo"").value =candidato[i].possuiVeiculo ;
          document.getElementById(""habilitacao"").");
            WriteLiteral(@"value =candidato[i].tipoHabilitacao ;
          document.getElementById(""nome"").value =candidato[i].nomeCandidato ;
          //document.getElementById(""vaga"").value =candidato. ;
          document.getElementById(""dataNascimento"").value =candidato[i].dataNascimento ;
          document.getElementById(""estadoCivil"").value =candidato[i].estadoCivil ;
          document.getElementById(""sexo"").value =candidato[i].genero ;
          document.getElementById(""cep"").value =candidato[i].cep ;
          document.getElementById(""endereco"").value =candidato[i].endereco ;
          document.getElementById(""numero"").value =candidato[i].numero ;
          document.getElementById(""complemento"").value =candidato[i].complemento ;
          document.getElementById(""bairro"").value =candidato[i].bairro ;
          document.getElementById(""cidade"").value =candidato[i].cidade ;
          document.getElementById(""estado"").value = candidato[i].uf;
          document.getElementById(""telCelular"").value = candidato[i].telefoneMovel;
  ");
            WriteLiteral(@"        document.getElementById(""telFixo"").value =candidato[i].telefoneFixo ;
          document.getElementById(""email"").value = candidato[i].emailCandidato;
        }
      }
    	// The API call was successful!
    	//return cep
    }).catch(function (err) {
    	// There was an error
    	console.warn('Something went wrong.', err);
    });
  }
  //criando listas
  geraUf();
</Script>









<table class=""table"">
    <thead>
        <tr>
            <th>
                candidato id
            </th>
            <th>
                nome do candidato
            </th>
            <th>
                estado civil
            </th>
            <th>
                genero
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 283 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
         foreach (var candidato in (List<Candidato>)ViewBag.Candidatos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 286 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
           Write(candidato.candidatoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 289 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
           Write(candidato.nomeCandidato);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 292 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
           Write(candidato.estadoCivil);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 295 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
           Write(candidato.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 298 "C:\Users\mathe\Desktop\Projeto final\mvp_principal-main\Views\Candidato\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>");
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
