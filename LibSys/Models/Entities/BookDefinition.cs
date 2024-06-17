using System.ComponentModel;

namespace LibSys.Models.Entities
{
    public class BookDefinition
    {
        public Guid Id { get; set; }
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Autor")]
        public string Author { get; set; }
    }
}
