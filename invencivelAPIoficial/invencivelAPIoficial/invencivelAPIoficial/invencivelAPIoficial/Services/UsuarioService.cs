
using Dapper;
using System.Data;

namespace invencivelAPIoficial.Services
{
    public class UsuarioService : UsuarioInterface
    {
        private readonly IDbConnection _db;

        public UsuarioService(IDbConnection db)
        {
            _db = db;
        }
        public async Task<bool> CadastrarUsuario(string nome, string email, string senha)
        {

            string sql = "INSERT INTO Usuario (Usuariocol, UsuarioEmail, UsuarioSenha) VALUES (@Nome, @Email, @Senha)";

            return await _db.ExecuteAsync(sql, new { Nome = nome, Email = email, Senha = senha }) > 0;
        }
    }
}
