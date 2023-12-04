using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPsiquiatricoMVC.Models;

namespace WebPsiquiatricoMVC.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly LabPsiquiatricoContext _context;

        public UsuariosController(LabPsiquiatricoContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var labPsiquiatricoContext = _context.Usuarios.Where(x => x.Estado != -1).Include(u => u.IdPersonalNavigation);
            return View(await labPsiquiatricoContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            //ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Nombre");
            //return View();

            ViewData["IdPersonal"] = new SelectList(_context.Personals.Where(x => x.Estado != -1 && x.Estado != 0).Select(x => new
            {
                x.Id,
                Nombre = $"{x.Nombre}"
            }).ToList(), "Id", "Nombre");

            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPersonal,Usuario1")] Usuario usuario)
        {
            if (!string.IsNullOrEmpty(usuario.Usuario1))
            {
                usuario.Clave = Util.Encrypt("sis457");
                usuario.UsuarioRegistro = User.Identity?.Name;
                usuario.FechaRegistro = DateTime.Now;
                usuario.Estado = 1;
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Id", usuario.IdPersonal);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["IdPersonal"] = new SelectList(_context.Personals.Where(x => x.Estado != -1 && x.Estado != 0), "Id", "Nombre", usuario.IdPersonal);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPersonal,Usuario1,Clave,UsuarioRegistro,FechaRegistro,Estado")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(usuario.Usuario1))
            {
                try
                {
                    usuario.UsuarioRegistro = User.Identity?.Name;
                    usuario.FechaRegistro = DateTime.Now;
                    usuario.Clave = Util.Encrypt("sis457");
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Nombre", usuario.IdPersonal);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'LabPsiquiatricoContext.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                usuario.Estado = -1;
                //_context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return (_context.Usuarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
