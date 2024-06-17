using LibSys.Models.Dto;

namespace LibSys.Models.Interfaces
{
    public interface IBookService
    {
        IEnumerable<AvailableBookDto> GetAvailableBooksForGuests();

        public bool BookExists(Guid id);
    }
}