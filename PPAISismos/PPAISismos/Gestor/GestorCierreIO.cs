using PPAISismos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Gestor
{
    public class GestorCierreIO
    {
        //Atributos
        private PantallaCierreOI pantallaCierreOI { get; set; }


        //Constructor
        public GestorCierreIO(PantallaCierreOI pantalla)
        {
            this.pantallaCierreOI = pantalla;
        }

        public void cerrarOI()
        {
            obtenerEmpleado();
        }
        public void obtenerEmpleado()
        {
        }
    }
}
