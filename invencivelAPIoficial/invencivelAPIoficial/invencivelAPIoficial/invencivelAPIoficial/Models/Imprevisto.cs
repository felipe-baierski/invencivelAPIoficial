using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Imprevisto")]
    public class Imprevisto
    {
        public int Imprevisto_id { get; set; }
        public string Imprevisto_nome { get; set; }
    }
}
