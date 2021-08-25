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
    public class CandidatoController : Controller
    {
        private readonly ILogger<CandidatoController> _logger;

        public CandidatoController(ILogger<CandidatoController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        { 
            ViewBag.Vagas = await ApiService.GetVagas();
            ViewBag.Candidatos = await ApiService.GetCandidatos();
            
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
