using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Flujo;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase, IModeloController
    {
        private IModeloFlujo _modeloFlujo;
        private ILogger<ModeloResponse> _logger;

        public ModeloController(IModeloFlujo modeloFlujo, ILogger<ModeloResponse> logger)
        {
            _modeloFlujo = modeloFlujo;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _modeloFlujo.Obtener();
            if (!resultado.Any())
                return NoContent();
            return Ok(resultado);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            var resultado = await _modeloFlujo.Obtener(Id);
            return Ok(resultado);
        }
    }
}
