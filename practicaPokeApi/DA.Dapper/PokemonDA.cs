using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DA.Dapper
{
    public class PokemonDA : IPokemonDA,IEquipoDA,IEntrenadorDA,IEntrenadorXPokemonDA
    {
        private readonly IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public PokemonDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }
        //----------------------------------------------------
        public async Task<Guid> Agregar(Entrenador entrenador)
        {
            string sql = @"AgregarEntrenador";
            var resultado = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new
            {
                nombre = entrenador.Nombre

            });
            return resultado;
        }

        public async Task<Guid> Agregar(EntrenadorXPokemon entrenadorXPokemon)
        {
            string sql = @"AgregarEntrenadorXPokemon";
            var resultado = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new
            {
                idEntrenador =entrenadorXPokemon.Entrenador,
                numeroPokemon = entrenadorXPokemon.Pokemons,
                idEquipo = entrenadorXPokemon.Equipo
            });
            return resultado;
        }

        public async Task<Guid> AgregarEquipo(Equipo equipo)
        {
            string sql = @"AgregarEquipo";
            var resultado = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new
            {
                idEntrenador = equipo.Entrenador,
                nombre=equipo.Nombre

            });
            return resultado;
        }

        public async Task<Guid> AgregarPokemon(Pokemon pokemon)
        {
            string sql = @"AgregarPokemon";
            var resultado = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new
            {
                nombre=pokemon.Nombre,
                tipo=pokemon.Tipo,
                sprite=pokemon.Sprite,
                crie=pokemon.Crie,
                nivel=pokemon.Nivel

            });
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

        public  Task<Entrenador> Obtener(Guid idEntrenador)
        {
            throw new NotImplementedException();
        }

        public  async Task<Equipo> ObtenerPorId(Guid idEquipo)
        {
            string sql = @"ObtenerEquipo"; 
            var equipo = await _sqlConnection.QueryFirstOrDefaultAsync<Equipo>(sql, new { IdEquipo = idEquipo });
            return equipo;
        }

        public Task<Pokemon> ObtenerPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pokemon>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        Task<EntrenadorXPokemon> IEntrenadorXPokemonDA.Obtener(Guid idEntrenadorXPokemon)
        {
            throw new NotImplementedException();
        }

         async Task<IEnumerable<Equipo>> IEquipoDA.ObtenerTodos()
        {
            string sql = @"ObtenerEquipos";
            var resultado = await _sqlConnection.QueryAsync<Equipo>(sql);
            if (!resultado.Any())
                return null;
            return resultado;
        }

         async Task<IEnumerable<Entrenador>> IEntrenadorDA.ObtenerTodos()
        {
            string sql = @"ObtenerEntrenadores";
            var resultado = await _sqlConnection.QueryAsync<Entrenador>(sql);
            if (!resultado.Any())
                return null;
            return resultado;
        }

        async Task<IEnumerable<EntrenadorXPokemon>> IEntrenadorXPokemonDA.ObtenerTodos()
        {
            string sql = @"ObtenerEntrenadorXPokemons";
            var resultado = await _sqlConnection.QueryAsync<EntrenadorXPokemon>(sql);
            if (!resultado.Any())
                return null;
            return resultado;
        }
    }
}
