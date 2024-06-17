using System.ComponentModel;

namespace LibSys.Models.Entities
{
    public class Borrowing
    {
        public Guid Id { get; set; }
        [DisplayName("Id książki")]
        public Guid BookId { get; set; }
        [DisplayName("Data wypożyczenia")]
        public DateTime BorrowDate { get; set; }
        [DisplayName("Termin oddania")]
        public DateTime ReturnDate { get; set; }
        [DisplayName("Książka")]
        public virtual Book? Book { get; set; }
        [DisplayName("Id czytelnika")]
        public Guid ReaderId { get; set; }
        [DisplayName("Czytelnik")]
        public virtual Reader? Reader { get; set; }
    }
}