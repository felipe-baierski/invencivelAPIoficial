using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Imprevisto")]
    public class ImprevistoModel
    {
        public int Imprevisto_id { get; set; }

        public string? Imprevisto_nome { get; set; }

        public string? Imprevisto_tipo { get; set; }

        public DateTime? Imprevisto_data { get; set; }

        public string? Imprevisto_gravidade { get; set; }

        public string? Imprevisto_local { get; set; }

        public string? Imprevisto_descricao { get; set; }
    }
}
