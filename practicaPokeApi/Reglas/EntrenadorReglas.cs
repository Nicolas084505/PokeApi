using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class EntrenadorReglas : IEntrenadorReglas
    {
        public Entrenador DarFormatoNombre(Entrenador entrenador)
        {
            entrenador.Nombre=entrenador.Nombre.ToUpper();
            return entrenador;
        }
    }
}
