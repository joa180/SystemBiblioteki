using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibSys.Data;
using LibSys.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using LibSys.Models.Interfaces;

namespace LibSys.Controllers
{
    public class BorrowingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBorrowingService _borrowingService;

        public BorrowingsController(ApplicationDbContext context, IBorrowingService borrowingService)
        {
            _context = context;
            _borrowingService = borrowingService;
        }

        public IActionResult ReaderBorrowings()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReaderBorrowings(Guid readerId)
        {
            var borrowings = _borrowingService.GetBorrowingsForReader(readerId);
            return View(borrowings);
        }

        // GET: Borrowings
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Borrowings.Include(b => b.Book).Include(b => b.Reader);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Borrowings/Details/5
        [Authorize]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Borrowings == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowings
                .Include(b => b.Book)
                .Include(b => b.Reader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowing == null)
            {
                return NotFound();
            }

            return View(borrowing);
        }

        // GET: Borrowings/Create
        [Authorize]
        public IActionResult Create(Guid? itemId)
        {
            ViewData["BookId"] = itemId == null ? new SelectList(_context.Books, "Id", "Id") : new SelectList(_context.Books, "Id", "Id", itemId);
            ViewData["ReaderId"] = new SelectList(_context.Readers, "Id", "Id");
            return View();
        }

        // POST: Borrowings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,BorrowDate,ReturnDate,ReaderId")] Borrowing borrowing)
        {
            if (ModelState.IsValid)
            {
                borrowing.Id = Guid.NewGuid();
                _context.Add(borrowing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", borrowing.BookId);
            ViewData["ReaderId"] = new SelectList(_context.Readers, "Id", "Id", borrowing.ReaderId);
            return View(borrowing);
        }

        // GET: Borrowings/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Borrowings == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", borrowing.BookId);
            ViewData["ReaderId"] = new SelectList(_context.Readers, "Id", "Id", borrowing.ReaderId);
            return View(borrowing);
        }

        // POST: Borrowings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BookId,BorrowDate,ReturnDate,ReaderId")] Borrowing borrowing)
        {
            if (id != borrowing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_borrowingService.BorrowingExists(borrowing.Id))
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
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", borrowing.BookId);
            ViewData["ReaderId"] = new SelectList(_context.Readers, "Id", "Id", borrowing.ReaderId);
            return View(borrowing);
        }

        // GET: Borrowings/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Borrowings == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowings
                .Include(b => b.Book)
                .Include(b => b.Reader)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowing == null)
            {
                return NotFound();
            }

            return View(borrowing);
        }

        // POST: Borrowings/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Borrowings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Borrowings'  is null.");
            }
            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing != null)
            {
                _context.Borrowings.Remove(borrowing);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
