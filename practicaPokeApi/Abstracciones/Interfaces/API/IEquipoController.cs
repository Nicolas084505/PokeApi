using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
namespace Abstracciones.Interfaces.API
{
    public interface IEquipoController
    {
        [HttpGet]
        Task<IActionResult> ObtenerTodos();
        [HttpGet]
        Task<IActionResult> ObtenerPorId(Guid idEquipo);
        [HttpPost]
        Task<IActionResult> AgregarEquipo(Equipo equipo);
        [HttpPut]
        Task<IActionResult> EditarEquipo(Equipo equipo); 
        [HttpDelete]
        Task<IActionResult> EliminarEquipo(Guid idEquipo);
        
        
    }
}
