using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sisgef.Controllers
{
    public class Veiculo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
