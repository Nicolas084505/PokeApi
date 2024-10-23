using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.Interfaces.API;
using Abstracciones.Modelos;
using Abstracciones.Interfaces.Flujo;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorXPokemonController : ControllerBase, IEntrenadorXPokemonController
    {
        private readonly IEntrenadorXPokemonFlujo _entrenadorXPokemonFlujo;

        public EntrenadorXPokemonController(IEntrenadorXPokemonFlujo entrenadorXPokemonFlujo)
        {
            _entrenadorXPokemonFlujo = entrenadorXPokemonFlujo;
        }
        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody] EntrenadorXPokemon entrenadorXPokemon)
        {
            var resultado = await _entrenadorXPokemonFlujo.Agregar(entrenadorXPokemon);
            return Ok(resultado);
        }

        public Task<IActionResult> Editar(EntrenadorXPokemon entrenadorXPokemon)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Eliminar(Guid idEntrenadorXPokemon)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{idEntrenadorXPokemon}")]
        public async Task<IActionResult> Obtener(Guid idEntrenadorXPokemon)
        {
            var resultado = await _entrenadorXPokemonFlujo.Obtener(idEntrenadorXPokemon);
            if (resultado == null)
                return NoContent();
            return Ok(resultado);
        }
        [HttpGet]
        public  async Task<IActionResult> ObtenerTodos()
        {
            var resultado = await _entrenadorXPokemonFlujo.ObtenerTodos();
            if (resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
