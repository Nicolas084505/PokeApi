using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.DA
{
    public interface IEntrenadorXPokemonDA
    {
        Task<IEnumerable<EntrenadorXPokemon>> ObtenerTodos();
        Task<EntrenadorXPokemon> Obtener(Guid idEntrenadorXPokemon);
        Task<Guid> Agregar(EntrenadorXPokemon entrenadorXPokemon);
        Task<Guid> Editar(EntrenadorXPokemon entrenadorXPokemon);
        Task<Guid> Eliminar(Guid idEntrenadorXPokemon);
    }
}
