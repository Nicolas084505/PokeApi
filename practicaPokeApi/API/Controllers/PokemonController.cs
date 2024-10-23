using Abstracciones.Interfaces.Flujo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.Interfaces.API;
using Abstracciones.Modelos;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase, IPokemonController
    {

        private readonly IPokemonFlujo _pokemonFlujo;

        public PokemonController(IPokemonFlujo pokemonFlujo)
        {
            _pokemonFlujo = pokemonFlujo;
        }
        [HttpPost]
        public async Task<IActionResult> AgregarPokemon([FromBody] Pokemon pokemon)
        {
            var resultado = await _pokemonFlujo.AgregarPokemon(pokemon);
            return Ok(resultado);
        }

        public Task<IActionResult> EditarPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> EliminarPokemon(int numero)
        {
            throw new NotImplementedException();
        }
        [HttpGet("{numero}")]
        public async Task<IActionResult> ObtenerPorNumero(int numero)
        {
            var resultado = await _pokemonFlujo.ObtenerPorNumero(numero);
            if (resultado == null)
                return NoContent();
            return Ok(resultado);
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var resultado = await _pokemonFlujo.ObtenerTodos();
            if (resultado.Any())
                return NoContent();
            return Ok(resultado);
        }
    }
}
