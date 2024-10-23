using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.Interfaces.API;
using Abstracciones.Modelos;
using Abstracciones.Interfaces.Flujo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase, IEquipoController
    {

        private readonly IEquipoFlujo _equipoFlujo;

        public EquipoController(IEquipoFlujo equipoFlujo)
        {
            _equipoFlujo = equipoFlujo;
        }


        [HttpPost]
        public  async Task<IActionResult> AgregarEquipo([FromBody] Equipo equipo)
        {
            var resultado = await _equipoFlujo.AgregarEquipo(equipo);
            return Ok(resultado);
        }

        public Task<IActionResult> EditarEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> EliminarEquipo(Guid idEquipo)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{idEquipo}")]
        public async Task<IActionResult> ObtenerPorId(Guid idEquipo)
        {
            var resultado = await _equipoFlujo.ObtenerPorId(idEquipo);
            if (resultado == null)
                return NoContent();
            return Ok(resultado);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var resultado = await _equipoFlujo.ObtenerTodos();
            if (resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
