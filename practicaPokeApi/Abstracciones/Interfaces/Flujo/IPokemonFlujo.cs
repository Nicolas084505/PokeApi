using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IPokemonFlujo
    {
        Task<IEnumerable<Pokemon>> ObtenerTodos();
        Task<Pokemon> ObtenerPorNumero(int numero);
        Task<int> AgregarPokemon(Pokemon pokemon);
        Task<int> EditarPokemon(Pokemon pokemon);
        Task<int> EliminarPokemon(int numero);
    }
}
