using PPAISismos.Entidades;
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
        private Sesion sesionActual { get; set; }
        private Empleado empladoLogueado { get; set; }


        //Constructor
        public GestorCierreIO(PantallaCierreOI pantalla,Sesion sesion)
        {
            this.pantallaCierreOI = pantalla;
            this.sesionActual = sesion;

        }

        public void cerrarOI()
        {
            obtenerEmpleado();
        }
        public void obtenerEmpleado()
        {
            empladoLogueado = sesionActual.getUsuario();
            //ESto es solo para probar que traiga bien el empleado
            //Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            //Console.WriteLine(empladoLogueado.getNombre());
        }
    }
}
