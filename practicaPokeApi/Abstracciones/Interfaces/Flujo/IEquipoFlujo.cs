using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IEquipoFlujo
    {
        Task<IEnumerable<Equipo>> ObtenerTodos();
        Task<Equipo> ObtenerPorId(Guid idEquipo);
        Task<Guid> AgregarEquipo(Equipo equipo);
        Task<Guid> EditarEquipo(Equipo equipo);
        Task<Guid> EliminarEquipo(Guid idEquipo);
        
    }
}
