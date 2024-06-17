using LibSys.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace LibSys.Models.Interfaces
{
    public interface IBorrowingService
    {
        public IEnumerable<ReaderBorrowingDto> GetBorrowingsForReader(Guid readerId);
        public bool BorrowingExists(Guid id);
    }
}
