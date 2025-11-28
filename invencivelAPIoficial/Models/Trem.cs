using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Trem")]
    public class Trem
    {
        public int Id_trem { get; set; }
        public string? Nome_trem { get; set; }
        public string? Cor_trem { get; set; }
        public string? Vagao_trem { get; set; }
        public double Velocidade_trem { get; set; }
        public double KmRodado_trem { get; set; }
        public string? LugarVisitado_trem { get; set; }
        public float ValorPassagem_trem { get; set; }
        public string? Atraso_trem { get; set; }
        public string? Onde_trem { get; set; }
        public string? ProxParada_trem { get; set; }
        public string? Demora_trem { get; set; }
    }

}
