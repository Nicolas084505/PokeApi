using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Equipo
    {
        public Guid IdEquipo { get; set; }
        public string Nombre { get; set; }

        public Entrenador Entrenador { get; set; }
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
    }
}
