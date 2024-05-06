using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestor_de_treas___P1.Data;
using Gestor_de_treas___P1.Models;

namespace Gestor_de_treas___P1.Controllers
{
    public class EtiquetasController : Controller
    {
        private readonly Gestor_de_treas___P1Context _context;

        public EtiquetasController(Gestor_de_treas___P1Context context)
        {
            _context = context;
        }

        // GET: Etiquetas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Etiqueta.ToListAsync());
        }

        // GET: Etiquetas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiqueta
                .FirstOrDefaultAsync(m => m.EtiquetaId == id);
            if (etiqueta == null)
            {
                return NotFound();
            }

            return View(etiqueta);
        }

        // GET: Etiquetas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Etiquetas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EtiquetaId,Nombre,Color")] Etiqueta etiqueta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(etiqueta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(etiqueta);
        }

        // GET: Etiquetas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiqueta.FindAsync(id);
            if (etiqueta == null)
            {
                return NotFound();
            }
            return View(etiqueta);
        }

        // POST: Etiquetas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EtiquetaId,Nombre,Color")] Etiqueta etiqueta)
        {
            if (id != etiqueta.EtiquetaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(etiqueta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EtiquetaExists(etiqueta.EtiquetaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(etiqueta);
        }

        // GET: Etiquetas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var etiqueta = await _context.Etiqueta
                .FirstOrDefaultAsync(m => m.EtiquetaId == id);
            if (etiqueta == null)
            {
                return NotFound();
            }

            return View(etiqueta);
        }

        // POST: Etiquetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var etiqueta = await _context.Etiqueta.FindAsync(id);
            if (etiqueta != null)
            {
                _context.Etiqueta.Remove(etiqueta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EtiquetaExists(int id)
        {
            return _context.Etiqueta.Any(e => e.EtiquetaId == id);
        }
    }
}
