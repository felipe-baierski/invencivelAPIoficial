using System.ComponentModel.DataAnnotations.Schema;

namespace invencivelAPIoficial.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Usuariocol { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioSenha { get; set; }
    }
}
