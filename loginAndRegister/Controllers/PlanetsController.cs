using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using starSystems.Data;
using starSystems.Models;

namespace starSystems.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly PlanetsContext _context;

        public PlanetsController(PlanetsContext context)
        {
            _context = context;
        }

        // GET: planet
        public async Task<IActionResult> Index(string planetStarSystem, string searchString)
        {
            if (_context.Planets == null)
            {
                return Problem("Entity set 'PlanetContext.Planet'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Planets
                                            orderby m.StarSystem
                                            select m.StarSystem;

            var planet = from m in _context.Planets
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                planet = planet.Where(s => s.Title!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(planetStarSystem))
            {
                planet = planet.Where(x => x.StarSystem == planetStarSystem);
            }

            var PlanetsStarSystemVM = new PlanetsStarSystemViewModel
            {
                starSystem = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Planets = await planet.ToListAsync()
            };

            return View(PlanetsStarSystemVM);
        }

        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.planet.ToListAsync());
        //}

        // GET: planet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planets = await _context.Planets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planets == null)
            {
                return NotFound();
            }

            return View(planets);
        }

        // GET: planet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: planet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,StarId,StarSystem")] Planets planets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planets);
        }

        // GET: planet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planets = await _context.Planets.FindAsync(id);
            if (planets == null)
            {
                return NotFound();
            }
            return View(planets);
        }

        // POST: planet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,StarId,StarSystem")] Planets planets)
        {
            if (id != planets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanetsExists(planets.Id))
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
            return View(planets);
        }

        // GET: planet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planets = await _context.Planets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planets == null)
            {
                return NotFound();
            }

            return View(planets);
        }

        // POST: planet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planets = await _context.Planets.FindAsync(id);
            if (planets != null)
            {
                _context.Planets.Remove(planets);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanetsExists(int id)
        {
            return _context.Planets.Any(e => e.Id == id);
        }
    }
}
