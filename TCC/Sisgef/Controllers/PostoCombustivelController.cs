using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sisgef.Models;

namespace Sisgef.Controllers
{
    public class PostoCombustivelController : Controller
    {
        private readonly ApplicationContext _context;

        public PostoCombustivelController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PostoCombustivel
        public async Task<IActionResult> Lista()
        {
            return View(await _context.PostoCombustivel.ToListAsync());
        }


        public IActionResult AddEdit(int id = 0)
        {
            if (id == 0)
                return View(new PostoCombustivel());
            else
                return View(_context.PostoCombustivel.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("Id, Cnpj, Nome, Bandeira, Telefone, Rua, Numero, Bairro")] PostoCombustivel postoCombustivel)
        {
            if (ModelState.IsValid)
            {
                if (postoCombustivel.Id == 0)
                    _context.Add(postoCombustivel);
                else
                    _context.Update(postoCombustivel);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Lista));
            }
            return View(postoCombustivel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var posto = await _context.PostoCombustivel.FindAsync(id);
            _context.PostoCombustivel.Remove(posto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Lista));
        }


    }

}
