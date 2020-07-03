using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sisgef;
using Sisgef.Models;

namespace Sisgef.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ApplicationContext _context;

        public VeiculoController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Veiculo
        public async Task<IActionResult> Lista()
        {
            return View(await _context.Veiculo.ToListAsync());
        }
        public IActionResult AddEditVeiculo(int id = 0)
        {
            
            if (id == 0)
                return View(new Veiculo());
            else
                return View(_context.Veiculo.Find(id));
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditVeiculo([Bind("Renavam, NomeDoProprietario, CpfCnpj, Placa, Chassi, Proprio, TipoDoVeiculo, Combustivel, Marca, Modelo, AnoFabricacao, TipoCarroceria, Cor, Odometro, Observacao,LocalDeEmplacamento ")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                if (veiculo.Id == 0)
                    _context.Add(veiculo);
                else
                    _context.Update(veiculo);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Lista));
            }
            return View(veiculo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var veiculo = await _context.Veiculo.FindAsync(id);
            _context.Veiculo.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }

        
    }
}
