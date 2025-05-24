using PPAISismos.Entidades;
using PPAISismos.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAISismos.Gestor
{
    public class GestorCierreOI
    {
        // Atributos:
        private PantallaCierreOI pantallaCierreOI;
        private Sesion sesionActual;
        private Empleado empleadoLogueado;
        // Lista de ordenes de inspección (OI)
        private List<OrdenDeInspeccion> ordenesDeInspeccion;
       
        // Estación sismológica (ES) de la OI
        private EstacionSismologica estacionSismologicaOI;
        private string nombreES;
        // Lista de sismógrafos
        private List<Sismografo> sismografos;
       

        private int nroOrden;
        private DateTime fechaFinalizacionOrden;

        private int identificadorSismografo;

        // Para encontrar las oiDeEmpleado realizadas, Sismografo y nombreEstacion
        private List<(OrdenDeInspeccion, Sismografo, string)> ordenesRealizadasConSismografoYEstacion;
        // lista de atributos 
        private List<(int NumeroOrden, DateTime FechaFinalizacion, string NombreEstacion, int IdentificadorSismografo)> listaParaPantalla;

        //OI SELECCIONADA
        private (OrdenDeInspeccion, Sismografo, string) ordenSeleccionada;
        private int numeroOrdenSeleccionada; // No se usa
        private string observacionIngresada;

        //Lista de tipos motivos para mostrar en la pantalla de cierre
        private List<MotivoTipo> listaTipoMotivo;
        private string descripcionTipoMotivo;
        //para guardarlos y dsp usarlo con el CE del sismografo
        List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios;

        //Lista de estados
        List<EstadoOI> listaEstadosOI;

        DateTime fechaHoraActual;

        //Lista de estados sismografo
        List<EstadoSismografo> listaEstadosSismografo;

        // nombre del estado FueraServicio del sismografo para luego pasrlso a a la notificacion OBERSVACION 2
        string nombreEstadoSismografoFueraServicio;

        // Lista de empleados
        List<Empleado> listaEmpleados;
        // Interfaz de correo
        InterfazMail interfazMail;
        // Lista de monitores
        List<Monitor> listaMonitores;

        // Constructor del gestor
        public GestorCierreOI(PantallaCierreOI pantalla)
        {
            this.pantallaCierreOI = pantalla;
            // Cargar sesión actual
            Sesion sesion = Data.Data.loadSesion();
            this.sesionActual = sesion;
            // Cargar lista de OI
            ordenesDeInspeccion = Data.Data.loadOrdenesDeInspeccion();
            // Cargar lista de sismógrafos
            sismografos = Data.Data.loadSismografos();
            //cargar lista de motivos
            listaTipoMotivo = Data.Data.loadMotivosTipos();
            //cargar lista estados OI
            listaEstadosOI = Data.Data.loadListaEstadoOI();
            //cargar lista de estados sismografo
            listaEstadosSismografo = Data.Data.loadListaEstadoSismografo();
            // Cargar lista de empleados
            listaEmpleados = Data.Data.loadEmpleados();
            // Cargar lista de monitores
            listaMonitores = Data.Data.loadListaMonitores();
            // Cargar interfaz de correo
            InterfazMail interfazMail = Data.Data.loadInterfazMail();
            this.interfazMail = interfazMail;
        }

        public void cerrarOI()
        {
            empleadoLogueado = obtenerEmpleado();
            // Console.WriteLine(empleadoLogueado.getNombre());
            obtenerOrdenesRealizadasDeEmpleado(empleadoLogueado);

            pantallaCierreOI.solicitarSeleccionOI(listaParaPantalla);
        }
        
        public Empleado obtenerEmpleado()
        {
            return sesionActual.getUsuario();
        }

        public void obtenerOrdenesRealizadasDeEmpleado(Empleado empleadoLogueado)
        {
            
            ordenesRealizadasConSismografoYEstacion = new List<(OrdenDeInspeccion,Sismografo,string)>();
            listaParaPantalla = new List<(int NumeroOrden, DateTime FechaFinalizacion, string NombreEstacion, int IdentificadorSismografo)>();
            foreach (OrdenDeInspeccion oi in ordenesDeInspeccion)
            {
                if (oi.esDeEmpleado(empleadoLogueado) && oi.verificarOIRealizada()) 
                {
                    estacionSismologicaOI = oi.obtenerES();
                    nombreES = oi.getNombreES();
                    nroOrden = oi.getNumeroOrden();
                    fechaFinalizacionOrden = oi.getFechaFinalizacion();
                    foreach (Sismografo sismografo in sismografos)
                    {
                        if (sismografo.esTuES(estacionSismologicaOI))
                        {
                            identificadorSismografo = sismografo.getIdentificador();
                            ordenesRealizadasConSismografoYEstacion.Add((oi, sismografo, nombreES));
                            listaParaPantalla.Add((nroOrden, fechaFinalizacionOrden, nombreES, identificadorSismografo));
                        }
                    }
                    
                }
            }
            ordenarListaOIPorFechaFinalizacion();

        }

        public void ordenarListaOIPorFechaFinalizacion()
        {
            // Crear una lista de índices ordenados por la fecha de finalización (descendente)
            //1.Calculas el orden correcto(índices) usando una sola lista(la de dominio).
            var indicesOrdenados = listaParaPantalla
            .Select((x, idx) => new { Fecha = x.FechaFinalizacion, idx })
            .OrderByDescending(x => x.Fecha)
            .Select(x => x.idx)
            .ToList();

            // Reordenar ambas listas usando los mismos índices
            ordenesRealizadasConSismografoYEstacion = indicesOrdenados.Select(i => ordenesRealizadasConSismografoYEstacion[i]).ToList();
            listaParaPantalla = indicesOrdenados.Select(i => listaParaPantalla[i]).ToList();
        }

        public void tomarOrdenSeleccionada(int row) {

            ordenSeleccionada = ordenesRealizadasConSismografoYEstacion[row];
            var ordenConAtributosSeleccionada = listaParaPantalla[row];
            pantallaCierreOI.solicitarObservacion(ordenConAtributosSeleccionada.NumeroOrden);

        }

       

        public void tomarObservacion(string observacion)
        {
            observacionIngresada = observacion;
            buscarTipoMotivo();
        }

        public void buscarTipoMotivo()
        {
            var listaDescipcionTipoMotivoParaPantalla = new List<string>();
            foreach (MotivoTipo motivo in listaTipoMotivo)
            {
                descripcionTipoMotivo = motivo.getDescripcion();
                listaDescipcionTipoMotivoParaPantalla.Add(descripcionTipoMotivo);
            }
            pantallaCierreOI.solicitarSeleccionTipoMotivo(listaDescipcionTipoMotivoParaPantalla);

        }

        public void tomarMotivosYComentarios(List<(int motivoIndex, string comentario)> motivosYComentarios)
        {
            motivosSeleccionadosConComentarios = new List<(MotivoTipo, string)>();
            foreach (var (motivoIndex, comentario) in motivosYComentarios)
            {
                MotivoTipo motivo = listaTipoMotivo[motivoIndex];
                motivosSeleccionadosConComentarios.Add((motivo, comentario));
                //Esto es para probar nomas
                //Console.WriteLine($"Motivo: {motivo.getDescripcion()} (índice {motivoIndex}) - Comentario: {comentario}");
                // Aquí puedes crear el MotivoFueraServicio, asociar el comentario, etc.
            }
            pantallaCierreOI.solicitarConfirmacion();
        }


        //A ESTE HAY QUE HACERLE UN REFACTOR

        public void tomarConfirmacion()
        {
            if (validarDatosMinimos())
            {
                //ESTO LO PODEMOS PASAR A QUE SEA UN ATTRIBUTO Y CAPAZ HASTA MEJOR
                EstadoOI estadoOICerrada = buscarEstadoOICerrada();
                getFechaHoraActual();
                actualizarOrden(estadoOICerrada);
                EstadoSismografo estadoSismografoFueraservicio = buscarEstadoSismografoFueraServicio();
                nombreEstadoSismografoFueraServicio = estadoSismografoFueraservicio.getNombre();
                ponerSismografoFueraServicio(estadoSismografoFueraservicio);
                var listaMails = buscarMailResponsableDeReparaciones();
                var notificacion = generarNotificacion(identificadorSismografo, nombreEstadoSismografoFueraServicio, fechaHoraActual, motivosSeleccionadosConComentarios);
                notificarMail(notificacion, listaMails);
                notificarMonitores(notificacion);
                finCU();

            } else { 
                //NOTIFICAR A LA PANTALLA ESTO ES UN FLUJO ALTERNATIVO
                Console.WriteLine("No se puede cerrar la OI, faltan datos.");
            }
        }

        public bool validarDatosMinimos(){
            if (!string.IsNullOrWhiteSpace(observacionIngresada)) {
                if(motivosSeleccionadosConComentarios != null && motivosSeleccionadosConComentarios.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un tipo de motivo.", "Faltan motivos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else {                 
                MessageBox.Show("Debe ingresar una observación de cierre.", "Falta observación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public EstadoOI buscarEstadoOICerrada()
        {
            foreach(var estadoOI in listaEstadosOI)
            {
                if (estadoOI.esCerrada())
                {
                    return estadoOI;

                }
            }
            return null; // Si no se encuentra el estado, puedes manejarlo como desees

        }
        public void getFechaHoraActual()
        {
          fechaHoraActual = DateTime.Now;
        }

        public void actualizarOrden(EstadoOI estadoOICerrada)
        {
            //NO OLVIDARS DE DESPUES COMENTAR LOS METODOS DE LAS CLASES ESTAS PORQUE SOLO SON PARA PROBAR
            //SOLO PARA PROBAR 
            Console.WriteLine("ANTES DE CERRAR ORDEN:");
            Console.WriteLine($"Estado: {ordenSeleccionada.Item1.getNombreEstadoOI()?.ToString() ?? "null"}");
            Console.WriteLine($"FechaHoraCierre: {ordenSeleccionada.Item1.getFechaHoraCierre()?.ToString() ?? "null"}");
            Console.WriteLine($"Observacion: {ordenSeleccionada.Item1.getObservacionCierre() ?? "null"}");


            //Actualizar la OI
            ordenSeleccionada.Item1.cerrarOI(estadoOICerrada, fechaHoraActual, observacionIngresada);

            ////SOLO PARA PROBAR 
            Console.WriteLine("DESPUÉS DE CERRAR ORDEN:");
            Console.WriteLine($"Estado: {ordenSeleccionada.Item1.getNombreEstadoOI()?.ToString() ?? "null"}");
            Console.WriteLine($"FechaHoraCierre: {ordenSeleccionada.Item1.getFechaHoraCierre()?.ToString() ?? "null"}");
            Console.WriteLine($"Observacion: {ordenSeleccionada.Item1.getObservacionCierre() ?? "null"}");

           
        }

        public EstadoSismografo buscarEstadoSismografoFueraServicio()
        {
            foreach (var estadoSismografo in listaEstadosSismografo)
            {
                if (estadoSismografo.esFueraServicio())
                {
                    return estadoSismografo;
                }
            }
            return null; // Si no se encuentra el estado, puedes manejarlo como desees
        }
        
        public void ponerSismografoFueraServicio(EstadoSismografo estadoSismografoFueraServicio)
        {
            Console.WriteLine("PROBANDO CAMBIAR ESTO SISMOGRAFO");
            //ESTO ES SOLO PARA PROBAR ANTES
            mostrarCambioEstadoActual(ordenSeleccionada.Item2);
            //ME OLVIDE DE PASARLE EL EMPLEADOOOOOO
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA // BORRÁ LOS MENSAJES SI YA ESTÁ SOLUCIONADO WACHO
            ordenSeleccionada.Item2.ponerSismografoFueraServicio(estadoSismografoFueraServicio, fechaHoraActual, motivosSeleccionadosConComentarios, empleadoLogueado);
            // ESTO ES SOLO PARA PROBAR EL DESPUES
            mostrarCambioEstadoActual(ordenSeleccionada.Item2);
        }

        //ESTO ES SOLO PARA PROBAR
        private void mostrarCambioEstadoActual(Sismografo sismografo)
        {
            var cambios = sismografo.getListaCambioEstadoSismografo();
            var cambioActual = cambios.FirstOrDefault(c => c.getFechaHoraFin() == null);

            if (cambioActual != null)
            {
                Console.WriteLine("----- Cambio de Estado Actual del Sismógrafo -----");
                Console.WriteLine($"  Estado: {cambioActual.getEstadoSismografo()?.getNombre() ?? "null"}");
                Console.WriteLine($"  Fecha Inicio: {cambioActual.getFechaHoraInicio()}");
                Console.WriteLine($"  Fecha Fin: {cambioActual.getFechaHoraFin()?.ToString() ?? "null"}");
                var motivos = cambioActual.getMotivosFueraServicio();
                if (motivos != null && motivos.Count > 0)
                {
                    foreach (var motivo in motivos)
                    {
                        Console.WriteLine($"    Motivo: {motivo.getMotivoTipo().getDescripcion()} - Comentario: {motivo.getComentario()}");
                    }
                }
                else
                {
                    Console.WriteLine("    Sin motivos asociados.");
                }
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("No hay cambio de estado actual (fecha fin == null) en el sismógrafo.");
            }
        }

        private List<string> buscarMailResponsableDeReparaciones()
        {
            var listaMails = new List<string>();
            foreach (Empleado empleado in listaEmpleados)
            {
                if (empleado.buscarResponsable())
                {
                    listaMails.Add(empleado.getMail());
                }
            }
            return listaMails;
        }

        // PARA MÍ TENDRÍA QUE IR UN GENERARNOTIFICACION()
        private string generarNotificacion(int identificadorSismografo, string nombreEstadoSismografoFueraServicio, DateTime fechaHoraActual, List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios)
        {
            Console.WriteLine("Generando notificación...");
            return "Imaginar que esto es una notificación";
        }

        private void notificarMail(string notificacionGenerada, List<string> listaMails)
        {
            foreach (string mail in listaMails)
            {
                interfazMail.enviarMail(notificacionGenerada, mail);
            }
        }

        private void notificarMonitores(string notificacionGenerada)
        {
            foreach (Monitor monitor in listaMonitores)
            {
                monitor.publicar(notificacionGenerada);
            }
        }

        private void finCU()
        {
            pantallaCierreOI.Close();
        }
    }
}
