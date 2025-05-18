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


        //LA DEJE POR LAS DUDAS NOMAS
        //public bool esRealizada()
        //{
        //    return nombre.Equals("Realizada", StringComparison.OrdinalIgnoreCase);
        //}
        public bool esRealizada() { return nombre == "Realizada"; }
        public bool esCerrada() { return nombre == "Cerrada"; }

        //Getters y Setters AGREGARLOS EN CASO DE SER UN METODO ESPECIFICO QUE SE USE EN EL DIAGRAMA DE SECUENCIA

    }
}
