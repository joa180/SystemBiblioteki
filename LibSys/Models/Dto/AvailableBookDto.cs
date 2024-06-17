using System.ComponentModel;

namespace LibSys.Models.Dto
{
    public class AvailableBookDto
    {
        public Guid Id { get; set; }
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Autor")]
        public string Author { get; set; }
        [DisplayName("Ilość")]
        public int Count { get; set; }
    }
}
