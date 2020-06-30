using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Rotativa.AspNetCore;
using Sisgef.Models;

namespace Sisgef.Controllers
{
    public class RequisicaoController : Controller
    {
        private readonly ApplicationContext _context;

        public RequisicaoController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Requisicao
        public async Task<IActionResult> Lista()
        {
            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Modelo");

            return View(await _context.Requisicao.ToListAsync());
        }
        public IActionResult AddEdit(int id = 0)
        {
            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Modelo");


            if (id == 0)
                return View();
            else
                return View(_context.Requisicao.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("Id, Data, Responsavel, TipoDeServico, Observacao, Motorista, Valor, FornecedorId, VeiculoId")] Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                if (requisicao.Id == 0)
                    _context.Add(requisicao);
                else
                    _context.Update(requisicao);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Lista));
            }

            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Modelo");

            return View(requisicao);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            var veiculo = await _context.Requisicao.FindAsync(id);
            _context.Requisicao.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }

        public IActionResult GerarPDF(int id)
        {
         
            return new ViewAsPdf("GerarPDF");
        }

        public async Task<IActionResult> Edit([Bind("Id, Data, Responsavel, TipoDeServico, Observacao, Motorista, Valor, FornecedorId, VeiculoId")] Requisicao requisicao)
        {
            _context.Update(requisicao);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));

            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Modelo");

            return View(requisicao);

        }

    }
}

