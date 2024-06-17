using LibSys.Data;
using LibSys.Models.Dto;
using LibSys.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Models.Services
{
    public class BorrowingService : IBorrowingService
    {
        private readonly ApplicationDbContext _context;

        public BorrowingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ReaderBorrowingDto> GetBorrowingsForReader(Guid readerId)
        {
            return _context
                .Borrowings.Where(borrowing => borrowing.ReaderId == readerId)
                .Include(b => b.Book)
                .Include(b => b.Book.BookDefinition)
                .Select(
                    b => 
                        new ReaderBorrowingDto
                        {
                            Title = b.Book.BookDefinition.Title,
                            BorrowDate = b.BorrowDate,
                            ReturnDate = b.ReturnDate
                        }
                ).ToList();
        }

        public bool BorrowingExists(Guid id)
        {
            return (_context.Borrowings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
