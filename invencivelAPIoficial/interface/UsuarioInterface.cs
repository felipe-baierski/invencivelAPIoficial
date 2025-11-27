namespace invencivelAPIoficial 
{
    public interface UsuarioInterface
    {
        public Task<bool> CadastrarUsuario(string nome, string email, string senha);
    }
}
