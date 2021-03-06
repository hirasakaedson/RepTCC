﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Sisgef.Models;

namespace Sisgef.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ApplicationContext _context;

        public FornecedorController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PostoCombustivel
        public async Task<IActionResult> Lista(string pesquisa = "")
        {
            if (pesquisa == null)
            {
                return View("ListaErro");
            }
            return View(await _context.Fornecedor.Where(x => x.Nome.Contains(pesquisa)).ToListAsync());
        }


        public IActionResult AddEditFornecedor(int id = 0)
        {
            if (id == 0)
                return View(new Fornecedor());
            else
                return View(_context.Fornecedor.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEditFornecedor([Bind("Id, Email, CpfCnpj, Nome, Observacao, Contato, Contato2, Posto, Rua, Numero, Bairro")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                if (fornecedor.Id == 0)
                    _context.Add(fornecedor);
                else
                    _context.Update(fornecedor);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Lista));
            }
            return View(fornecedor);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var fornecedor = await _context.Fornecedor.FindAsync(id);
            _context.Fornecedor.Remove(fornecedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }


    }

}
