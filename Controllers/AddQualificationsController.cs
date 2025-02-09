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
    public class AddQualificationsController : Controller
    {
        private readonly ApplicationContext _context;

        public AddQualificationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: AddQualifications
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.AddQualifications.Include(a => a.Personal);
            return View(await applicationContext.ToListAsync());
        }

        // GET: AddQualifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addQualification = await _context.AddQualifications
                .Include(a => a.Personal)
                .FirstOrDefaultAsync(m => m.ProgramId == id);
            if (addQualification == null)
            {
                return NotFound();
            }

            return View(addQualification);
        }

        // GET: AddQualifications/Create
        public IActionResult Create()
        {
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId");
            return View();
        }

        // POST: AddQualifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramId,PersonalId,Program,Institute,FromDate,ToDate,Percentage,Division")] AddQualification addQualification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addQualification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", addQualification.PersonalId);
            return View(addQualification);
        }

        // GET: AddQualifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addQualification = await _context.AddQualifications.FindAsync(id);
            if (addQualification == null)
            {
                return NotFound();
            }
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", addQualification.PersonalId);
            return View(addQualification);
        }

        // POST: AddQualifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProgramId,PersonalId,Program,Institute,FromDate,ToDate,Percentage,Division")] AddQualification addQualification)
        {
            if (id != addQualification.ProgramId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addQualification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddQualificationExists(addQualification.ProgramId))
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
            ViewData["PersonalId"] = new SelectList(_context.PersonalDetails, "PersonalId", "PersonalId", addQualification.PersonalId);
            return View(addQualification);
        }

        // GET: AddQualifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addQualification = await _context.AddQualifications
                .Include(a => a.Personal)
                .FirstOrDefaultAsync(m => m.ProgramId == id);
            if (addQualification == null)
            {
                return NotFound();
            }
            return View(addQualification);
        }

        // POST: AddQualifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addQualification = await _context.AddQualifications.FindAsync(id);
            if (addQualification != null)
            {
                _context.AddQualifications.Remove(addQualification);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddQualificationExists(int id)
        {
            return _context.AddQualifications.Any(e => e.ProgramId == id);
        }
    }
}
