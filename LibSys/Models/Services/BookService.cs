using LibSys.Data;
using LibSys.Models.Dto;
using LibSys.Models.Entities;
using LibSys.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Models.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AvailableBookDto> GetAvailableBooksForGuests()
        {
            Dictionary<Guid, AvailableBookDto> bookDefinitions =
                new Dictionary<Guid, AvailableBookDto>();
            List<AvailableBookDto> availableBooks = new List<AvailableBookDto>();

            var books = _context
                .Books.Include(b => b.BookDefinition)
                .Where(b => b.Status == BookStatus.Available);

            foreach (var book in books)
            {
                if (bookDefinitions.ContainsKey(book.BookDefinitionId))
                {
                    ++bookDefinitions[book.BookDefinitionId].Count;
                }
                else
                {
                    var availableBook = new AvailableBookDto
                    {
                        Id = book.Id,
                        Author = book.BookDefinition.Author,
                        Title = book.BookDefinition.Title,
                        Count = 1
                    };
                    availableBooks.Add(availableBook);
                    bookDefinitions[book.BookDefinitionId] = availableBook;
                }
            }

            return availableBooks;
        }

        public bool BookExists(Guid id)
        {
            return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
