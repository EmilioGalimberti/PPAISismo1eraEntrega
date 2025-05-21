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
        // Atributos:
        private PantallaCierreOI pantallaCierreOI { get; set; }
        private Sesion sesionActual { get; set; }
        private Empleado empleadoLogueado { get; set; }
        // Lista de ordenes de inspección (OI)
        private List<OrdenDeInspeccion> ordenesDeInspeccion;
        // Para encontrar las oiDeEmpleado realizadas, mostrar identificacionSismografo y nombreEstacion
        private List<(OrdenDeInspeccion, int, string)> oiDeEmpleadoRealizadasyNroSismografo { get; set; }
        // Estación sismológica (ES) de la OI
        private EstacionSismologica estacionSismologicaOI;
        // Lista de sismógrafos
        private List<Sismografo> sismografos { get; set; }
        // Lista de tipos de motivo
        private List<TipoMotivo> tiposDeMotivo { get; set; }

        // OI seleccionada
        private (OrdenDeInspeccion, int, string) ordenSeleccionada;
        // Lista de tipos de motivo y comentarios
        private List<(string tipoMotivo, string comentario)> tiposMotivoYComentarios = new List<(string, string)>();

        // Constructor del gestor
        public GestorCierreIO(PantallaCierreOI pantalla)
        {
            this.pantallaCierreOI = pantalla;
            // Cargar sesión actual
            Sesion sesion = Data.Data.loadSesion();
            this.sesionActual = sesion;
            // Cargar lista de OI
            ordenesDeInspeccion = Data.Data.loadOrdenesDeInspeccion();
            // Cargar lista de sismógrafos
            sismografos = Data.Data.loadSismografos();
            // Cargar lista de tipos de motivo
            tiposDeMotivo = Data.Data.loadTiposDeMotivo();
        }

        public void cerrarOI()
        {
            empleadoLogueado = obtenerEmpleado();
            // Console.WriteLine(empleadoLogueado.getNombre());
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
                if (oi.esDeEmpleado(empleadoLogueado) && oi.verificarOIRealizada()) 
                {
                    estacionSismologicaOI = oi.obtenerES();
                    foreach (Sismografo sismografo in sismografos)
                    {
                        if (sismografo.esTuES(estacionSismologicaOI))
                        {

                            oiDeEmpleadoRealizadasyNroSismografo.Add((oi, sismografo.getIdentificador(), oi.getNombreEs()));
                            
                        }
                    }
                    
                }
            }
            oiDeEmpleadoRealizadasyNroSismografo = ordenarOIPorFechaFinal(oiDeEmpleadoRealizadasyNroSismografo);

            //ESTO LO HAGO PARA PODER EVITAR LA DEPENDENCIA DE LA PANTALLA CON LA OI, porque osino le pasaba una oi directamente preguntar si esto tendria que estar en el diagrama de secuecnia, el obtener nro y la fecha
            // Transforma la lista de tuplas de dominio a una lista de tuplas simples
            var listaParaPantalla = oiDeEmpleadoRealizadasyNroSismografo
                .Select(tupla => (
                    tupla.Item1.getNumeroOrden(),
                    tupla.Item1.getFechaFinalizacion(),
                    tupla.Item3, // NombreEstacion
                    tupla.Item2  // IdentificadorSismografo
                ))
                .ToList();

            // Ahora pasas solo datos simples a la pantalla
         
            pantallaCierreOI.solicitarSeleccionOI(listaParaPantalla);
            
        }

        public List<(OrdenDeInspeccion, int, string)> ordenarOIPorFechaFinal(List<(OrdenDeInspeccion, int, string)> lista)
        {
            //ordenar por fecha de finalizacion
            return lista.OrderByDescending(x => x.Item1.getFechaFinalizacion()).ToList();
        }


        public void tomarOrdenSeleccionada(int row) {

            ordenSeleccionada = oiDeEmpleadoRealizadasyNroSismografo[row];
            //ACA PREGUNTAR SI POR EJEMPLO ESTE GET NUMERO ORDEN HABIRA QUE AGG EN EL DIAGRAMA DE SECUENCIA
            pantallaCierreOI.solicitarObservacion(ordenSeleccionada.Item1.getNumeroOrden());

        }

        public void tomarObservacion(string observacion)
        {
            Console.WriteLine(observacion);
            buscarTipoMotivo();
        }

        private void buscarTipoMotivo()
        {
            List<string> descripciones = new List<string>();
            foreach (TipoMotivo tipoMotivo in tiposDeMotivo)
            {
                descripciones.Add(tipoMotivo.getDescripcion());
            }
            pantallaCierreOI.solicitarSeleccionTipoMotivo(descripciones);
        }

        public void tomarSeleccionTipoMotivo(string tipoMotivoSeleccionado)
        {
            // TODO: Implementar la lógica para manejar la selección del tipo de motivo
            Console.WriteLine($"Tipo de motivo seleccionado: {tipoMotivoSeleccionado}");
            pantallaCierreOI.solicitarComentario();
        }

        public void tomarIngresoComentario(string comentario)
        {
            // Obtener el tipo de motivo seleccionado actualmente
            string tipoMotivoSeleccionado = pantallaCierreOI.getTipoMotivoSeleccionado();
            
            // Agregar el par tipo de motivo y comentario a la lista
            tiposMotivoYComentarios.Add((tipoMotivoSeleccionado, comentario));
            
            // TODO: Implementar la lógica para manejar el comentario
            Console.WriteLine($"Comentario ingresado para {tipoMotivoSeleccionado}: {comentario}");
        }

        public void tomarConfirmacionCierre(bool confirmado)
        {
            if (confirmado)
            {
                // TODO: Implementar la lógica para cerrar la orden de inspección
                Console.WriteLine("Orden de inspección cerrada exitosamente");
                Console.WriteLine("Tipos de motivo y comentarios registrados:");
                foreach (var (tipoMotivo, comentario) in tiposMotivoYComentarios)
                {
                    Console.WriteLine($"- {tipoMotivo}: {comentario}");
                }
            }
            else
            {
                Console.WriteLine("Cierre de orden de inspección cancelado");
            }
        }
    }
}
