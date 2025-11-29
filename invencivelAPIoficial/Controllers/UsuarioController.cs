using invencivelAPIoficial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace invencivelAPIoficial.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioInterface usuarioInterface;
        public UsuarioController(UsuarioInterface usuarioInterface)
        {
            this.usuarioInterface = usuarioInterface;
        }
        [HttpPost("CadastroUsuario")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] LoginRequest usuario)
        {

            var cadastroSucesso = await usuarioInterface.CadastrarUsuario(usuario.UsuarioNome, usuario.UsuarioEmail, usuario.UsuarioSenha);

            if (cadastroSucesso)
            {
                return Ok(new { mensagem = "Usuário cadastrado com sucesso!" });
            }
            else
            {
                return Ok(new { mensagem = "Usuário já existente" });
            }
        }

        [HttpGet("ObterTodosUsuarios")]
        public async Task<IActionResult> ObterTodosUsuarios()
        {
            var usuarios = await usuarioInterface.ObterTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUsuario([FromBody] LoginRequest usuario)
        {
            var loginSucesso = await usuarioInterface.LoginUsuario(usuario.UsuarioEmail, usuario.UsuarioSenha);
            if (loginSucesso)
            {
                return Ok(new { mensagem = "Login bem-sucedido!" });
            }
            else
            {
                return Ok(new { mensagem = "Credenciais inválidas." });
            }
        }

    }
}
