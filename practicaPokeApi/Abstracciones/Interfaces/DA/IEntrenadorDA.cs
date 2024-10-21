using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.DA
{
    public interface IEntrenadorDA
    {
        Task<IEnumerable<Entrenador>> ObtenerTodos();
        Task<Entrenador> Obtener(Guid idEntrenador);
        Task<Guid> Agregar(Entrenador entrenador);
        Task<Guid> Editar(Entrenador entrenador);
        Task<Guid> Eliminar(Guid idEntrenador);

    }
}
