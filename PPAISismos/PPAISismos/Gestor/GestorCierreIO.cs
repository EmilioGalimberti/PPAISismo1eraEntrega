using PPAISismos.Entidades;
using PPAISismos.Interfaces;
using System;
using System.Collections;
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

        //para encontrar las oiDeEmpleado realizadas, mostrar IdentifciacionSismografo y  y nombre Estacion)
        private List<(OrdenDeInspeccion, int, string)> oiDeEmpleadoRealizadasyNroSismografo { get; set; }
        //ES de la OI
        private EstacionSismologica estacionSismologicaOI;
        //lista de sismografos
        private List<Sismografo> sismografos { get; set; }
        //Constructor
        public GestorCierreIO(PantallaCierreOI pantalla)
        {
            this.pantallaCierreOI = pantalla;

            //Cargar sesion actual
            Sesion sesion = Data.Data.loadSesion();
            this.sesionActual = sesion;

            //cargar lista de ordenes de inspeccion
            ordenesDeInspeccion = Data.Data.loadOrdenesDeInspeccion();
            //carga lista de sismografos
            sismografos = Data.Data.loadSismografos();
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

        //A este seria mejor cambiarle el nombre, porque son las realizadas pero en mi diagrama lo tenia asi
        public void buscarOICompletadas(Empleado empleadoLogueado)
        {
            
            oiDeEmpleadoRealizadasyNroSismografo = new List<(OrdenDeInspeccion,int,string)>();
            foreach (OrdenDeInspeccion oi in ordenesDeInspeccion)
            {
                //nose si dejarlo en un if o separarlo en dos, pero como no hacemos los
                // option en el diagrama de secuencia
                // prefiero no seperarlo porque ahi si seria hacer dos for each
                if (oi.esDeEmpleado(empleadoLogueado) && oi.verificarOIRealizada()) 
                {
                    estacionSismologicaOI = oi.obtenerES();
                    foreach (Sismografo sismografo in sismografos)
                    {
                        if (sismografo.esTuES(estacionSismologicaOI))
                        {
                            //Fijarse si logramos que en vez de tener que ir a obtener el nombre podemos devolver una tupla
                            // con el obtenerES()
                            oiDeEmpleadoRealizadasyNroSismografo.Add((oi, sismografo.getIdentificador(), oi.getNombreEs()));
                            
                        }
                    }
                    
                }
                oiDeEmpleadoRealizadasyNroSismografo = ordenarOIPorFechaFinal(oiDeEmpleadoRealizadasyNroSismografo);
            }
            //FALTA ORGANIZARLAS POR FECHA DE FINALIZACION para eso darle fechas diferentes tmb en el data
            pantallaCierreOI.solicitarSeleccionOI(oiDeEmpleadoRealizadasyNroSismografo);
            
        }

        public List<(OrdenDeInspeccion, int, string)> ordenarOIPorFechaFinal(List<(OrdenDeInspeccion, int, string)> lista)
        {
            //ordenar por fecha de finalizacion
            return lista.OrderByDescending(x => x.Item1.getFechaFinalizacion()).ToList();
        }
    }
}
