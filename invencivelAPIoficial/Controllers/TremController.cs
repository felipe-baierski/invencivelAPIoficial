using Microsoft.AspNetCore.Mvc;

namespace invencivelAPIoficial.Controllers
{
    [ApiController]
        [Route("api/[Controller]")]
    public class TremController : ControllerBase
    {
        private readonly TremInterface tremInterface;

        public TremController(TremInterface trem)
        {
            tremInterface = trem;
        }

        [HttpGet("ObterNomeTrem")]
        public async Task<IActionResult> ObterTremNomeTrem()
        {
            var trem = await tremInterface.ObterTremNomesTrem();
            return Ok(trem);
        }
        [HttpGet("ObterDadosPorNome")]
        public async Task<IActionResult> ObterDadosPorNome([FromQuery] string nomeTrem)
        {
            var trem = await tremInterface.ObterDadosPorNome(nomeTrem);
            return Ok(trem);
        }

    }
}
