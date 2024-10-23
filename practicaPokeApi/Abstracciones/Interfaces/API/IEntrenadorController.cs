using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IEntrenadorController
    {
        [HttpGet]
        Task<IActionResult> ObtenerTodos();
        [HttpGet]
        Task<IActionResult> Obtener(Guid idEntrenador);
        [HttpPost]
        Task<IActionResult> Agregar(Entrenador entrenador);
        [HttpPut]
        Task<IActionResult> Editar(Entrenador entrenador);
        [HttpDelete]
        Task<IActionResult> Eliminar(Guid idEntrenador);
    }
}
