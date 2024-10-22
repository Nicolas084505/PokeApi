using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class EntrenadorXPokemon
    {
        public Guid idEntrenadorXPokemon { get; set; }
        public Entrenador Entrenador { get; set; }

        public Equipo Equipo { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();


    }
}
