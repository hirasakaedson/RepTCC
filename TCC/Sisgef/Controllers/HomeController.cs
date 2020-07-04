using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sisgef.Models;

namespace Sisgef.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext Contexto;
      
        public HomeController(ILogger<HomeController> logger, ApplicationContext contexto)
        {
            Contexto = contexto;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var VeiculoProprio = Contexto.Veiculo.Count(x => x.Proprio == "sim");
            ViewData["ContagemProprio"] = VeiculoProprio;

            var VeiculoTerceiro = Contexto.Veiculo.Count(x => x.Proprio == "nao");
            ViewData["ContagemTerceiro"] = VeiculoTerceiro;

            var ContagemRequisicao = Contexto.Requisicao.Count();
            ViewData["ContagemRequisicao"] = ContagemRequisicao;
            return View();
        }

        public IActionResult ListaProprio()
        {
            var VeiculoProprio = Contexto.Veiculo.Where(x => x.Proprio == "sim").ToList();

            return RedirectToAction("");
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
