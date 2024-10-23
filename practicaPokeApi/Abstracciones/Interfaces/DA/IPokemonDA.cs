using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.DA
{
    public interface IPokemonDA
    {
        Task<IEnumerable<Pokemon>> ObtenerTodos();     
        Task<Pokemon> ObtenerPorNumero(int numero);    
        Task<Guid> AgregarPokemon(Pokemon pokemon);     
        Task<int> EditarPokemon(Pokemon pokemon);      
        Task<int> EliminarPokemon(int numero);
    }
}
