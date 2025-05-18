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
        private Empleado empleadoLogueado { get; set; }
        //Lista de ordenes
        private List<OrdenDeInspeccion> ordenesDeInspeccion;

        //para encontrar las oiDeEmpleado
        private List<OrdenDeInspeccion> oiDeEmpleado { get; set; }

        //Constructor
        public GestorCierreIO(PantallaCierreOI pantalla)
        {
            this.pantallaCierreOI = pantalla;

            //Cargar sesion actual
            Sesion sesion = Data.Data.loadSesion();
            this.sesionActual = sesion;

            //cargar lista de ordenes de inspeccion
            ordenesDeInspeccion = Data.Data.loadOrdenesDeInspeccion();
        }

        public void cerrarOI()
        {
            empleadoLogueado = obtenerEmpleado();
            //Console.WriteLine(empleadoLogueado.getNombre());
            buscarOICompletadas(empleadoLogueado);
        }
        public Empleado obtenerEmpleado()
        {
            return sesionActual.getUsuario();
        }

        //A este seria mejor cambiarle el nombre ajsjas porque son las realizadas pero en mi diagrama lo tenia asi
        public void buscarOICompletadas(Empleado empleadoLogueado)
        {
            // a este atributo tmb hay que cambiarle el nombre oiDeEmpleadoRealizadas
            oiDeEmpleado = new List<OrdenDeInspeccion>();
            foreach (OrdenDeInspeccion oi in ordenesDeInspeccion)
            {
                //nose si dejarlo en un if o separarlo en dos, pero como no hacemos los
                // option en el diagrama de secuencia
                // prefiero no seperarlo porque ahi si seria hacer dos for each
                if (oi.esDeEmpleado(empleadoLogueado) && oi.verificarOIRealizada()) 
                {
                    oi.obtenerES();
                    oiDeEmpleado.Add(oi);
                    //Console.WriteLine(oi.getNumeroOrden());
                }
            }

        }
    }
}
