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

        public bool esRealizada()
        {
            return nombre.Equals("Realizada", StringComparison.OrdinalIgnoreCase);
        }

        //Getters y Setters AGREGARLOS EN CASO DE SER UN METODO ESPECIFICO QUE SE USE EN EL DIAGRAMA DE SECUENCIA

    }
}
