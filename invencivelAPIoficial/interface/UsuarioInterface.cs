using invencivelAPIoficial.Models;

namespace invencivelAPIoficial
{
    public interface UsuarioInterface
    {
        public Task<bool> CadastrarUsuario(string nome, string email, string senha);

        public Task<IEnumerable<Usuario>> ObterTodosUsuarios();

        public Task<bool> LoginUsuario(string email, string senha);
    }
}
