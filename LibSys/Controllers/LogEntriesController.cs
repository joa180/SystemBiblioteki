using LibSys.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Controllers
{
    public class LogEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LogEntries
        public async Task<IActionResult> Index()
        {
            return _context.LogEntries != null ?
                        View(await _context.LogEntries.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.LogEntries'  is null.");
        }

        // GET: LogEntries/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.LogEntries == null)
            {
                return NotFound();
            }

            var logEntry = await _context.LogEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logEntry == null)
            {
                return NotFound();
            }

            return View(logEntry);
        }
    }
}