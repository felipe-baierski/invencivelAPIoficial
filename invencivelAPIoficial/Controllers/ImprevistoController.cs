using Microsoft.AspNetCore.Mvc;

namespace invencivelAPIoficial.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ImprevistoController : ControllerBase
    {
        readonly Imprevisto imprevisto;

        public ImprevistoController(Imprevisto imprevisto)
        {
            this.imprevisto = imprevisto;
        }

        [HttpGet("UltimoCodigoAcidente")]
        public async Task<IActionResult> UltimoCodigoAcidente()
        {
            var resultado = await imprevisto.UltimoCodigoAcidente();
            return Ok(resultado);
        }
    }
}
