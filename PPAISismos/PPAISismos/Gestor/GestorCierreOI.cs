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
        private string observacionIngresada;

        //Lista de tipos motivos para mostrar en la pantalla de cierre
        private List<MotivoTipo> listaTipoMotivo;
        private string descripcionTipoMotivo;
        //para guardarlos y dsp usarlo con el CE del sismografo
        List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios;

        //Lista de estados
        private List<EstadoOI> listaEstadosOI;

        private DateTime fechaHoraActual;

        //Lista de estados sismografo
        private List<EstadoSismografo> listaEstadosSismografo;

        // nombre del estado FueraServicio del sismografo para luego pasrlso a a la notificacion OBERSVACION 2
        private string nombreEstadoSismografoFueraServicio;

        // Lista de empleados
        private List<Empleado> listaEmpleados;
        // Interfaz de correo
        private InterfazMail interfazMail;
        // Lista de monitores
        private List<Monitor> listaMonitores;

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
            obtenerOrdenesRealizadasDeEmpleado(empleadoLogueado);
            ordenarListaOIPorFechaFinalizacion();
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
            }
            pantallaCierreOI.solicitarConfirmacion();
        }

        public void tomarConfirmacion()
        {
            if (validarDatosMinimos())
            {
                EstadoOI estadoOICerrada = buscarEstadoOICerrada();
                getFechaHoraActual();
                actualizarOrden(estadoOICerrada);
                EstadoSismografo estadoSismografoFueraservicio = buscarEstadoSismografoFueraServicio();
                nombreEstadoSismografoFueraServicio = estadoSismografoFueraservicio.getNombre();
                ponerSismografoFueraServicio(estadoSismografoFueraservicio);
                var listaMails = buscarMailResponsableEnReparaciones();
                notificarMail(listaMails);
                notificarMonitores();
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
            return null; 

        }
        public void getFechaHoraActual()
        {
          fechaHoraActual = DateTime.Now;
        }

        public void actualizarOrden(EstadoOI estadoOICerrada)
        {
            //Actualizar la OI
            ordenSeleccionada.Item1.cerrarOI(estadoOICerrada, fechaHoraActual, observacionIngresada);
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
            return null;
        }
        
        public void ponerSismografoFueraServicio(EstadoSismografo estadoSismografoFueraServicio)
        {
            ordenSeleccionada.Item2.ponerSismografoFueraServicio(estadoSismografoFueraServicio, fechaHoraActual, motivosSeleccionadosConComentarios, empleadoLogueado);

        }
       

        private List<string> buscarMailResponsableEnReparaciones()
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

        private void notificarMail(List<string> listaMails)
        {
            foreach (string mail in listaMails)
            {
                Console.Write(mail);
                interfazMail.enviarMail(identificadorSismografo, nombreEstadoSismografoFueraServicio, fechaHoraActual, motivosSeleccionadosConComentarios, mail);
            }
        }

        private void notificarMonitores()
        {
            foreach (Monitor monitor in listaMonitores)
            {
                monitor.publicar(identificadorSismografo, nombreEstadoSismografoFueraServicio, fechaHoraActual, motivosSeleccionadosConComentarios);
            }
        }

        private void finCU()
        {
            pantallaCierreOI.Close();
        }
    }
}
