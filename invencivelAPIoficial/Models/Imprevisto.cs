using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Unicode;

namespace invencivelAPIoficial.Models
{
    [Table("Imprevisto")]
    public class Imprevisto
    {
        public int Imprevisto_id { get; set; }

        // Nome genérico que você tinha na sua classe antes
        public string Imprevisto_nome { get; set; }

        // === Colunas do Traffic Incident ===

        // Tipo do incidente: CRASH, ROAD_CLOSED, CONGESTION, etc.
        public string IncidentType { get; set; }

        // Severidade: LOW, MEDIUM, HIGH
        public string Severity { get; set; }

        // Distância da rota em metros
        public int DistanceMeters { get; set; }

        // Descrição detalhada do incidente
        public string Description { get; set; }

        // Data/hora de criação do registro
        public DateTime CreatedAt { get; set; }
    }
}
