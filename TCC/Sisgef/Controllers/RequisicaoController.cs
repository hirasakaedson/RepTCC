﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Lista(string pesquisa = "")
        {
            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Placa");
            if (pesquisa != "")
            {
                return View(await _context.Requisicao.Where(x => x.Veiculo.Placa.Contains(pesquisa)).ToListAsync());
            }
            return View(await _context.Requisicao.ToListAsync());
        }
       
        public IActionResult AddEditServico(int id = 0)
        {
            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Placa");


            if (id == 0)
                return View();
            else
                return View(_context.Requisicao.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditServico([Bind("Id, Data, Responsavel, TipoDeServico, Observacao, Motorista, Valor, Litros, VeiculoId, FornecedorId")] Requisicao requisicao)
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

        public async Task<IActionResult> GerarPDF(int id)
        {
            var requisicao = await _context.Requisicao
                .Include(x => x.Fornecedor)
                .Include(y => y.Veiculo)
                .FirstOrDefaultAsync(x => x.Id == id);

            return new ViewAsPdf("GerarPDF", requisicao);
        }


        public IActionResult AddEditCombustivel(int id = 0)
        {
            ViewBag.FornecedorId = new SelectList(_context.Fornecedor.Where(x => x.Posto == "sim").ToList(), "Id", "Nome");
            ViewBag.VeiculoId = new SelectList(_context.Veiculo.ToList(), "Id", "Placa");


            if (id == 0)
                return View();
            else
                return View(_context.Requisicao.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditCombustivel([Bind("Id, Data, Responsavel, Motorista, Valor, Litros, VeiculoId, FornecedorId, Combustivel")] Requisicao requisicao)
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

    }
}

