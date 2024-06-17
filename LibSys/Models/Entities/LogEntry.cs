using System.ComponentModel;

namespace LibSys.Models.Entities
{
    public class LogEntry
    {
        public Guid Id { get; set; }

        [DisplayName("Nazwa metody")]
        public string? MethodName { get; set; }

        [DisplayName("Encja")]
        public string EntityName { get; set; }

        [DisplayName("Zmiany")] 
        public string? EntityChanges { get; set; }

        [DisplayName("Czas zmiany")]
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }  
    }
}
