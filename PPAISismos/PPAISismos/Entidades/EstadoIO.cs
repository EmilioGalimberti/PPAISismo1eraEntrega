using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class EstadoIO
    {
        private string nombre;
        
        public EstadoIO(string nombre)
        {
            this.nombre = nombre;
        }

        public bool esRealizada()
        { 
            return nombre.Equals("Realizada", StringComparison.OrdinalIgnoreCase);
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
