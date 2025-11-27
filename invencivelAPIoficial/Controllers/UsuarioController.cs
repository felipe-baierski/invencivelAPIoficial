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
        public IActionResult CadastrarUsuario(string Nome, string email, string senha)
        {
            var cadastroSucesso = usuarioInterface.CadastrarUsuario(Nome, email, senha);



            if (cadastroSucesso.Result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
