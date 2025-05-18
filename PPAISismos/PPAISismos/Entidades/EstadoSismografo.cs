using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class EstadoSismografo
    {
        private string nombre;

        public EstadoSismografo(string nombre)
        {
            this.nombre = nombre;
        }
        
        public bool esRealizada() { return nombre == "FueraDeServicio"; }
    }
}
