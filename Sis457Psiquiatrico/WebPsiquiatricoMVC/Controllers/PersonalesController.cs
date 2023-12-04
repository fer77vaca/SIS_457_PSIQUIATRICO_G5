using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPsiquiatricoMVC.Models;

namespace WebPsiquiatricoMVC.Controllers
{
    [Authorize]
    public class PersonalesController : Controller
    {
        private readonly LabPsiquiatricoContext _context;

        public PersonalesController(LabPsiquiatricoContext context)
        {
            _context = context;
        }

        // GET: Personales
        public async Task<IActionResult> Index()
        {
              return _context.Personals != null ? 
                          View(await _context.Personals.Where(x => x.Estado != -1).ToListAsync()) :
                          Problem("Entity set 'LabPsiquiatricoContext.Personals'  is null.");
        }

        // GET: Personales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personal == null)
            {
                return NotFound();
            }

            return View(personal);
        }

        // GET: Personales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,CedulaIdentidad,Especialidad,Telefono,HorarioTrabajo")] Personal personal)
        {
            if (!string.IsNullOrEmpty(personal.Nombre))
            {
                if (!Regex.IsMatch(personal.Nombre, "^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ()\\s]+$"))
                {
                    ModelState.AddModelError(nameof(personal.Nombre), "El campo Nombres solo puede contener letras");
                }
                personal.UsuarioRegistro = User.Identity?.Name;
                personal.FechaRegistro = DateTime.Now;
                personal.Estado = 1;
                _context.Add(personal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(personal);
        }

        // GET: Personales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals.FindAsync(id);
            if (personal == null)
            {
                return NotFound();
            }
            return View(personal);
        }

        // POST: Personales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,CedulaIdentidad,Especialidad,Telefono,HorarioTrabajo,UsuarioRegistro,FechaRegistro,Estado")] Personal personal)
        {
            if (id != personal.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(personal.Nombre))
            {
                try
                {
                    personal.UsuarioRegistro = User.Identity?.Name;
                    personal.FechaRegistro = DateTime.Now;
                    _context.Update(personal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalExists(personal.Id))
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
            return View(personal);
        }

        // GET: Personales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personal == null)
            {
                return NotFound();
            }

            return View(personal);
        }

        // POST: Personales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personals == null)
            {
                return Problem("Entity set 'LabPsiquiatricoContext.Personals'  is null.");
            }
            var personal = await _context.Personals.FindAsync(id);
            if (personal != null)
            {
                personal.Estado = -1;
                personal.UsuarioRegistro = User.Identity?.Name;
                //_context.Personals.Remove(personal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalExists(int id)
        {
          return (_context.Personals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
