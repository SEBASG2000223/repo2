using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase, IMarcaController
    {
        private IMarcaFlujo _marcaFlujo;
        private ILogger<MarcaResponse> _logger;

        public MarcaController(IMarcaFlujo marcaFlujo, ILogger<MarcaResponse> logger)
        {
            _marcaFlujo = marcaFlujo;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _marcaFlujo.Obtener();
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            var resultado = await _marcaFlujo.Obtener(Id);
            return Ok(resultado);
        }
    }
}
