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
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veiculos.ToListAsync());
        }

        // GET: Veiculo/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var veiculo = await _context.Veiculos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (veiculo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(veiculo);
        //}

        // GET: Veiculo/Create
        public IActionResult AddEdit(int id = 0)
        {
            if (id == 0)
                return View(new Veiculo());
            else
                return View(_context.Veiculos.Find(id));
        }

        // POST: Veiculo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEdit([Bind("Placa,Marca,Modelo,Id")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                if (veiculo.Id == 0)
                    _context.Add(veiculo);
                else
                    _context.Update(veiculo);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var veiculo = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Veiculo/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var veiculo = await _context.Veiculos.FindAsync(id);
        //    if (veiculo == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(veiculo);
        //}

        // POST: Veiculo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Placa,Marca,Modelo,Id")] Veiculo veiculo)
        //{
        //    if (id != veiculo.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(veiculo);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!VeiculoExists(veiculo.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(veiculo);
        //}

        // GET: Veiculo/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var veiculo = await _context.Veiculos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (veiculo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(veiculo);
        //}

        //    // POST: Veiculo/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var veiculo = await _context.Veiculos.FindAsync(id);
        //        _context.Veiculos.Remove(veiculo);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool VeiculoExists(int id)
        //    {
        //        return _context.Veiculos.Any(e => e.Id == id);
        //    }
    }
}
