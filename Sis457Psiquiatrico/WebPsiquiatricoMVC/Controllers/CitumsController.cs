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
    public class CitumsController : Controller
    {
        private readonly LabPsiquiatricoContext _context;

        public CitumsController(LabPsiquiatricoContext context)
        {
            _context = context;
        }
        // PARA GET
        // GET: Citums
        public async Task<IActionResult> Index()
        {
            var labPsiquiatricoContext = _context.Cita.Where(x => x.Estado != -1).Include(c => c.IdPacienteNavigation);
            return View(await labPsiquiatricoContext.ToListAsync());
        }

        // GET: Citums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (citum == null)
            {
                return NotFound();
            }

            return View(citum);
        }

        // GET: Citums/Create
        public IActionResult Create()
        {

            ViewData["IdPaciente"] = new SelectList(_context.Pacientes.Where(x => x.Estado != -1 && x.Estado != 0).Select(x => new
            {
                x.Id,
                Nombre = $"{x.Nombre}"
            }).ToList(), "Id", "Nombre");

            return View();
        }

        // POST: Citums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPaciente,Motivo,FechaReservacion,Pago")] Citum citum)
        {
            if (!string.IsNullOrEmpty(citum.Motivo))
            {
                citum.UsuarioRegistro = User.Identity?.Name;
                citum.FechaRegistro = DateTime.Now;
                citum.Estado = 1;
                _context.Add(citum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", citum.IdPaciente);
            return View(citum);
        }

        // GET: Citums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita.FindAsync(id);
            if (citum == null)
            {
                return NotFound();
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes.Where(x => x.Estado != -1 && x.Estado != 0), "Id", "Nombre", citum.IdPaciente);
            return View(citum);
        }

        // POST: Citums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPaciente,Motivo,FechaReservacion,Pago,UsuarioRegistro,FechaRegistro,Estado")] Citum citum)
        {
            if (id != citum.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(citum.Motivo))
            {
                try
                {
                    citum.UsuarioRegistro = User.Identity?.Name;
                    citum.FechaRegistro = DateTime.Now;
                    _context.Update(citum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitumExists(citum.Id))
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
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", citum.IdPaciente);
            return View(citum);
        }

        // GET: Citums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (citum == null)
            {
                return NotFound();
            }

            return View(citum);
        }

        // POST: Citums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cita == null)
            {
                return Problem("Entity set 'LabPsiquiatricoContext.Cita'  is null.");
            }
            var citum = await _context.Cita.FindAsync(id);
            if (citum != null)
            {
                citum.Estado = -1;
                citum.UsuarioRegistro = User.Identity?.Name;
                //_context.Cita.Remove(citum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CitumExists(int id)
        {
          return (_context.Cita?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
