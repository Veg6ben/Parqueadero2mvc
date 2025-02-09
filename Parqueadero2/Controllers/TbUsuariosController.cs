using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parqueadero2.Models;

namespace Parqueadero2.Controllers
{
    public class TbUsuariosController : Controller
    {
        private readonly DbParqueaderoContext _context;

        public TbUsuariosController(DbParqueaderoContext context)
        {
            _context = context;
        }

        // GET: TbUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbUsuarios.ToListAsync());
        }

        // GET: TbUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            return View(tbUsuario);
        }

        // GET: TbUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TbUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Cantidad,Precio,NumeroDePlaca,Modelo,Color")] TbUsuario tbUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbUsuario);
        }

        // GET: TbUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios.FindAsync(id);
            if (tbUsuario == null)
            {
                return NotFound();
            }
            return View(tbUsuario);
        }

        // POST: TbUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Cantidad,Precio,NumeroDePlaca,Modelo,Color")] TbUsuario tbUsuario)
        {
            if (id != tbUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbUsuarioExists(tbUsuario.Id))
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
            return View(tbUsuario);
        }

        // GET: TbUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbUsuario = await _context.TbUsuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            return View(tbUsuario);
        }

        // POST: TbUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbUsuario = await _context.TbUsuarios.FindAsync(id);
            if (tbUsuario != null)
            {
                _context.TbUsuarios.Remove(tbUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbUsuarioExists(int id)
        {
            return _context.TbUsuarios.Any(e => e.Id == id);
        }
    }
}
