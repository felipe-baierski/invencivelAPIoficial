using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public int Usuario_id { get; set; }
        public string Usuario_nome { get; set; }
        public string Usuario_email { get; set; }
        public string Usuario_senha { get; set; }
    }
}
