using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.API
{
    public interface IEntrenadorXPokemonController
    {
        [HttpGet]
        Task<IActionResult> ObtenerTodos();
        [HttpGet]
        Task<IActionResult> Obtener(Guid idEntrenadorXPokemon);
        [HttpPost]
        Task<IActionResult> Agregar(EntrenadorXPokemon entrenadorXPokemon);
        [HttpPut]
        Task<IActionResult> Editar(EntrenadorXPokemon entrenadorXPokemon);
        [HttpDelete]
        Task<IActionResult> Eliminar(Guid idEntrenadorXPokemon);
    }
}
