using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class EstadoOI
    {
        private string nombre;

        public EstadoOI(string nombre)
        {
            this.nombre = nombre;
        }

        public bool esCerrada()
        {
            return nombre.Equals("Cerrada", StringComparison.OrdinalIgnoreCase);
        }

        public bool esRealizada()
        {
            return nombre.Equals("CompletamenteRealizada", StringComparison.OrdinalIgnoreCase);
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
