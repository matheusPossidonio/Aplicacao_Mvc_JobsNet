using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aplicação_mvc_Principal.Models;
using Aplicação_mvc_Principal.Servicos;

namespace Aplicação_mvc_Principal.Controllers
{
     public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        { 
            //teste do crud de vagas 
            Vaga vagateste = new Vaga{nomeVaga= "Programador js",descricaoVaga = "Vaga para dev  js"};
            ViewBag.Vagas = await ApiService.PostVagas(vagateste);
            ViewBag.Vagas = await ApiService.GetVagas();

            //--testes do crud dos candidatos
            //criando  um candidato que ser usado no teste
             Candidato candidato_teste = new Candidato{
                 nomeCandidato = "Andressa", estadoCivil = "namorando", genero = "feminino",
                dataNascimento = "10/03/2000", cep = "5840755", endereco = "alto branco",
                numero = "884444486", complemento = "10", bairro = "alto branco", cidade = "Campina grande",
                uf = "pb", telefoneFixo = "33555889", telefoneMovel= " 8844556698", emailCandidato = "teste@gmail.com",
                cpf = "11122233348", rg = "4588779", possuiVeiculo = "sim", tipoHabilitacao = "A", vagaId = 1};
            //no put o candidato deve ter o id
            //ViewBag.Candidatos = await ApiService.PutCandidato(10,candidato_teste);
            ViewBag.Candidatos = await ApiService.PostCandidato(candidato_teste);
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
