using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorController : ControllerBase, IEntrenadorController
    {
        private readonly IEntrenadorFlujo  _entrenadorFlujo;

            public EntrenadorController(IEntrenadorFlujo entrenadorFlujo)
        {
            _entrenadorFlujo = entrenadorFlujo;
        }

        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody]Abstracciones.Modelos.Entrenador entrenador)
        {
            var resultado = await _entrenadorFlujo.Agregar(entrenador);
            return Ok(resultado);
        }

        public Task<IActionResult> Editar(Abstracciones.Modelos.Entrenador entrenador)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Eliminar(Guid idEntrenador)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{idEntrenador}")]
        public Task<IActionResult> Obtener(Guid idEntrenador)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var resultado = await _entrenadorFlujo.ObtenerTodos();
            if (resultado .Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
