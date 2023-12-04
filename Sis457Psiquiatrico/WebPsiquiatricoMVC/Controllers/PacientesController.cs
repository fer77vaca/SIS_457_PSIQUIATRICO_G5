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
    public class PacientesController : Controller
    {
        private readonly LabPsiquiatricoContext _context;

        public PacientesController(LabPsiquiatricoContext context)
        {
            _context = context;
        }

        // GET: Pacientes
        public async Task<IActionResult> Index()
        {
            var labPsiquiatricoContext = _context.Pacientes.Where(x => x.Estado != -1).Include(p => p.IdPersonalNavigation);
            return View(await labPsiquiatricoContext.ToListAsync());
        }

        // GET: Pacientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .Include(p => p.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        public IActionResult Create()
        {
            ViewData["IdPersonal"] = new SelectList(_context.Personals.Where(x => x.Estado != -1 && x.Estado != 0).Select(x => new
            {
                x.Id,
                Nombre = $"{x.Nombre}"
            }).ToList(), "Id", "Nombre");

            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPersonal,Nombre,CedulaIdentidad,Edad,Telefono,HistorialMedico,Tratamiento,FechaAdmision")] Paciente paciente)
        {
            if (!string.IsNullOrEmpty(paciente.Nombre))
            {
                paciente.UsuarioRegistro = User.Identity?.Name;
                paciente.FechaRegistro = DateTime.Now;
                paciente.Estado = 1;
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Id", paciente.IdPersonal);
            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            ViewData["IdPersonal"] = new SelectList(_context.Personals.Where(x => x.Estado != -1 && x.Estado != 0), "Id", "Nombre", paciente.IdPersonal);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPersonal,Nombre,CedulaIdentidad,Edad,Telefono,HistorialMedico,Tratamiento,UsuarioRegistro,FechaRegistro,Estado,FechaAdmision")] Paciente paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(paciente.Nombre))
            {
                try
                {
                    paciente.UsuarioRegistro = User.Identity?.Name;
                    paciente.FechaRegistro = DateTime.Now;
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
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
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Id", paciente.IdPersonal);
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .Include(p => p.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacientes == null)
            {
                return Problem("Entity set 'LabPsiquiatricoContext.Pacientes'  is null.");
            }
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                paciente.Estado = -1;
                paciente.UsuarioRegistro = User.Identity?.Name;
                //_context.Pacientes.Remove(paciente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(int id)
        {
          return (_context.Pacientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
