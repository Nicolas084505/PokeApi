using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Flujo
{
    internal class Flujo : IPokemonFlujo,IEquipoFlujo,IEntrenadorFlujo,IEntrenadorXPokemonDA
    {

        private readonly IPokemonDA _pokemonDA;
        private readonly IEquipoDA _equipoDA;
        private readonly IEntrenadorDA _entrenadorDA;
        private readonly IEntrenadorXPokemonDA _entrenadorxpokemonDA;
        private readonly IEntrenadorReglas _entrenadorReglas;

        // private readonly IPokemonService _pokemonService;

        public Flujo(IPokemonDA pokemonDA, IEquipoDA equipoDA, IEntrenadorDA entrenadorDA, IEntrenadorXPokemonDA entrenadorxpokemonDA, IEntrenadorReglas entrenadorReglas)
        {
            _pokemonDA = pokemonDA;
            _equipoDA = equipoDA;
            _entrenadorDA = entrenadorDA;
            _entrenadorxpokemonDA = entrenadorxpokemonDA;

        }



        public async Task<Guid> Agregar(Entrenador entrenador)
        {
           var resultado=await _entrenadorDA.Agregar(entrenador);
            return resultado;
        }

        public async Task<Guid> Agregar(EntrenadorXPokemon entrenadorXPokemon)
        {
            var resultado = await _entrenadorxpokemonDA.Agregar(entrenadorXPokemon);
            return resultado;
        }

        public async Task<Guid> AgregarEquipo(Equipo equipo)
        {
            var resultado = await _equipoDA.AgregarEquipo(equipo);
            return resultado;
        }

        public  async Task<Guid> AgregarPokemon(Pokemon pokemon)
        {
            var resultado = await _pokemonDA.AgregarPokemon(pokemon);
            return resultado;
        }

        public Task<Guid> Editar(Entrenador entrenador)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Editar(EntrenadorXPokemon entrenadorXPokemon)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> EditarEquipo(Equipo equipo)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditarPokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(Guid idEntrenador)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> EliminarEquipo(Guid idEquipo)
        {
            throw new NotImplementedException();
        }

        public Task<int> EliminarPokemon(int numero)
        {
            throw new NotImplementedException();
        }

        public Task<Entrenador> Obtener(Guid idEntrenador)
        {
            throw new NotImplementedException();
        }

        async public Task<Equipo> ObtenerPorId(Guid idEquipo)
        {
            var resultado = await _equipoDA.ObtenerPorId(idEquipo);
            return resultado;
        }

        public Task<Pokemon> ObtenerPorNumero(int numero)
        {
            var resultado = _pokemonDA.ObtenerPorNumero(numero);
            return resultado;
        }

        public Task<IEnumerable<Pokemon>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        Task<EntrenadorXPokemon> IEntrenadorXPokemonDA.Obtener(Guid idEntrenadorXPokemon)
        {
            throw new NotImplementedException();
        }

       async Task<IEnumerable<Equipo>> IEquipoFlujo.ObtenerTodos()
        {
            var resultado = await _equipoDA.ObtenerTodos();
            return resultado;
        }

        async Task<IEnumerable<Entrenador>> IEntrenadorFlujo.ObtenerTodos()
        {
            List<Entrenador> resultadoConFormato = new List<Entrenador>();
            var resultadoSinformato= await _entrenadorDA.ObtenerTodos();
            foreach (var entrenador in resultadoSinformato) 
            {
                resultadoConFormato.Add(_entrenadorReglas.DarFormatoNombre(entrenador));
            }
            return resultadoConFormato;

        }

        async Task<IEnumerable<EntrenadorXPokemon>> IEntrenadorXPokemonDA.ObtenerTodos()
        {
            var resultado = await _entrenadorxpokemonDA.ObtenerTodos();
            return resultado;
        }
    }
}
