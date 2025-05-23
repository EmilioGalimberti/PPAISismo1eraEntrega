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
   
        public bool esRealizada() { return nombre == "Realizada"; }
        public bool esCerrada() { return nombre == "Cerrada"; }


        //LO AGREGO PARA PROBAR QUE SE CAMBIE BIEN EL ESTADO AL CERRAR LA OI
        //COMENTAR METODO
        public string getNombre()
        {
            return nombre;
        }

    }
}
