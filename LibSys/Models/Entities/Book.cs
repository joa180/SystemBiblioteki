using System.ComponentModel;

namespace LibSys.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        [DisplayName("Id definicji")]
        public Guid BookDefinitionId { get; set; }
        [DisplayName("Definicja książki")]
        public virtual BookDefinition? BookDefinition { get; set; }
        [DisplayName("Uwagi")]
        public string? Comment { get; set; }
        public BookStatus Status { get; set; }
    }

    public enum BookStatus
    {
        Available,
        Borrowed,
        ForSale,
    }
}
