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
        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario([FromBody]Usuario usuario)
        {
            var cadastroSucesso = await usuarioInterface.CadastrarUsuario(usuario.Usuariocol, usuario.UsuarioEmail, usuario.UsuarioSenha);



            if (cadastroSucesso)
            {
                return Ok(new { mensagem = "Usuário cadastrado com sucesso!" });
            }
            else
            {
                return Ok(new { mensagem = "Usuário não cadastrado" });
            }

        }
    }
}
