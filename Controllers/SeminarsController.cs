using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SeminarsController : Controller
    {
        private readonly ApplicationContext _context;

        public SeminarsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Seminars
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Seminar.Include(s => s.Personal);
            return View(await applicationContext.ToListAsync());
        }

        // GET: Seminars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar
                .Include(s => s.Personal)
                .FirstOrDefaultAsync(m => m.SeminarId == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }
        // GET: Seminars/Create
        public IActionResult Create()
        {
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId");
            return View();
        }

        // POST: Seminars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SeminarId,PersonalId,SeminarName,ConductedBy,DurationFrom,DurationTo")] Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", seminar.PersonalId);
            return View(seminar);
        }

        // GET: Seminars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar.FindAsync(id);
            if (seminar == null)
            {
                return NotFound();
            }
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", seminar.PersonalId);
            return View(seminar);
        }

        // POST: Seminars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SeminarId,PersonalId,SeminarName,ConductedBy,DurationFrom,DurationTo")] Seminar seminar)
        {
            if (id != seminar.SeminarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeminarExists(seminar.SeminarId))
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
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", seminar.PersonalId);
            return View(seminar);
        }

        // GET: Seminars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar
                .Include(s => s.Personal)
                .FirstOrDefaultAsync(m => m.SeminarId == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // POST: Seminars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminar.FindAsync(id);
            if (seminar != null)
            {
                _context.Seminar.Remove(seminar);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeminarExists(int id)
        {
            return _context.Seminar.Any(e => e.SeminarId == id);
        }
    }
}
