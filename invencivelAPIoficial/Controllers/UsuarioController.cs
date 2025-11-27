using invencivelAPIoficial.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CadastrarUsuario([FromBody]Usuario usuario)
        {
            var cadastroSucesso = usuarioInterface.CadastrarUsuario(usuario.Usuariocol, usuario.UsuarioEmail, usuario.UsuarioSenha);



            if (cadastroSucesso.Result)
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
