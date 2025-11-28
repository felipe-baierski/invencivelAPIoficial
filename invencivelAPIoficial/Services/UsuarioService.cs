
using Dapper;
using invencivelAPIoficial.Models;
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
            string checkSql = "SELECT COUNT(*) FROM Usuario WHERE UsuarioEmail = @Email";
            int count = await _db.ExecuteScalarAsync<int>(checkSql, new { Email = email });

            if (count > 0)
            {
                // Usuário já existe
                return false;
            }

            // Insere se não existe
            string insertSql = "INSERT INTO Usuario (UsuarioNome, UsuarioEmail, UsuarioSenha) VALUES (@Nome, @Email, @Senha)";

            return await _db.ExecuteAsync(insertSql, new {Nome = nome, Email = email, Senha = senha}) > 0;
        }

        public async Task<bool> LoginUsuario(string email, string senha, string nome)
        {
            string sql = "SELECT * FROM Usuario WHERE UsuarioEmail = @Email AND UsuarioSenha = @Senha AND UsuarioNome = @Nome";

            var Query = await _db.QueryAsync<Usuario>(sql, new {Email = email, Senha = senha, Nome = nome});

            if (Query.Count() == 0)
            {
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            string sql = "SELECT * FROM Usuario";

            var usuarios = await _db.QueryAsync<Usuario>(sql);

            return usuarios;
        }
    }
}
