using System.ComponentModel;

namespace LibSys.Models.Entities
{
    public class Reader
    {
        public Guid Id { get; set; }

        [DisplayName("Imię i nazwisko")]
        public string Name { get; set; }

        [DisplayName("Miasto")]
        public string City { get; set; }

        [DisplayName("Ulica")]
        public string Street { get; set; }

        [DisplayName("Kod pocztowy")]
        public string Code { get; set; }
    }
}
