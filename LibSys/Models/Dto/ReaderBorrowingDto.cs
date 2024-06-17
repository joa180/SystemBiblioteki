using System.ComponentModel;

namespace LibSys.Models.Dto
{
    public class ReaderBorrowingDto
    {
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Data wypożyczenia")]
        public DateTime BorrowDate { get; set; }
        [DisplayName("Termin oddania")]
        public DateTime ReturnDate { get; set; }
    }
}
