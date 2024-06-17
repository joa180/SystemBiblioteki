using LibSys.Data;
using LibSys.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Controllers
{
    [Authorize]
    public class BookDefinitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookDefinitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookDefinitions
        public async Task<IActionResult> Index()
        {
            return _context.BookDefinitions != null ?
                        View(await _context.BookDefinitions.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.BookDefinitions'  is null.");
        }

        // GET: BookDefinitions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.BookDefinitions == null)
            {
                return NotFound();
            }

            var bookDefinition = await _context.BookDefinitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookDefinition == null)
            {
                return NotFound();
            }

            return View(bookDefinition);
        }

        // GET: BookDefinitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookDefinitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author")] BookDefinition bookDefinition)
        {
            if (ModelState.IsValid)
            {
                bookDefinition.Id = Guid.NewGuid();
                _context.Add(bookDefinition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookDefinition);
        }

        // GET: BookDefinitions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.BookDefinitions == null)
            {
                return NotFound();
            }

            var bookDefinition = await _context.BookDefinitions.FindAsync(id);
            if (bookDefinition == null)
            {
                return NotFound();
            }
            return View(bookDefinition);
        }

        // POST: BookDefinitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Author")] BookDefinition bookDefinition)
        {
            if (id != bookDefinition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookDefinition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookDefinitionExists(bookDefinition.Id))
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
            return View(bookDefinition);
        }

        // GET: BookDefinitions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.BookDefinitions == null)
            {
                return NotFound();
            }

            var bookDefinition = await _context.BookDefinitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookDefinition == null)
            {
                return NotFound();
            }

            return View(bookDefinition);
        }

        // POST: BookDefinitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.BookDefinitions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BookDefinitions'  is null.");
            }
            var bookDefinition = await _context.BookDefinitions.FindAsync(id);
            if (bookDefinition != null)
            {
                _context.BookDefinitions.Remove(bookDefinition);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookDefinitionExists(Guid id)
        {
            return (_context.BookDefinitions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}