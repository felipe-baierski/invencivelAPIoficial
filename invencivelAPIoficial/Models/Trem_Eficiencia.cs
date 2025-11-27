using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace invencivelAPIoficial.Models
{
    [Table("Trem_eficiencia")]
    public class Trem_Eficiencia
    {
        public string Te_atraso { get; set; }
        [ForeignKey("Trem_status_Trem_id")]
        public Trem_Status Trem_status { get; set; }
        public string? Te_estacao { get; set; }
        public string Te_parada { get; set; }
        public string Te_tempo { get; set; }

    }
}
