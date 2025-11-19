using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Trem_status")]
    public class Trem_Status
    {
        public int Trem_id { get; set; }
        public string Trem_cor { get; set; }
        public double Trem_velocidade { get; set; }
        public string Trem_KmRodado { get; set; }
        public string? Trem_lugarVisita {  get; set; }
        public float Trem_pasagem { get; set; }

    }
}
