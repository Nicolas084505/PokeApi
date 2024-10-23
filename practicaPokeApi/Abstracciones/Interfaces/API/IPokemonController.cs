using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
namespace Abstracciones.Interfaces.API
{
    public interface IPokemonController
    {
        [HttpGet]
        Task<IActionResult> ObtenerTodos();
        [HttpGet]
        Task<IActionResult> ObtenerPorNumero(int numero);
        [HttpPost]
        Task<IActionResult> AgregarPokemon(Pokemon pokemon);
        [HttpPut]
        Task<IActionResult> EditarPokemon(Pokemon pokemon);
        [HttpDelete]
        Task<IActionResult> EliminarPokemon(int numero);
    }
}
