using PPAISismos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Data
{
    public class Data
    {        
        // Roles (string nombre, string descripcion)
        // Buscar en el dominio más roles. Estos son de prueba:
        public static Rol ResponsableDeInspecciones { get; set; } = new Rol("ResponsableDeInspecciones", "Descripcion1");
        public static Rol AnalistaEnSismos { get; set; } = new Rol("AnalistaEnSismos", "Descripcion2");
        public static Rol AnalistaSupervisor { get; set; } = new Rol("AnalistaSupervisor", "Descripcion3");
        public static Rol EncargadoDeInstalaciones { get; set; } = new Rol("EncargadoDeInstalaciones", "Descripcion4");
        
        
        // Empleados (string nombre, string apellido, string mail, int telefono, Rol rol)
        public static Empleado Empleado1 { get; set; } = new Empleado("Germán", "Vélez", "mail@gmail.com", 3510000001, ResponsableDeInspecciones);
        public static Empleado Empleado2 { get; set; } = new Empleado("Marcela", "Cattaneo", "mail2@gmail.com", 3510000002, AnalistaEnSismos);
        public static Empleado Empleado3 { get; set; } = new Empleado("Salvador", "Barbera", "mail3@gmail.com", 3510000003, AnalistaSupervisor);
        public static Empleado Empleado4 { get; set; } = new Empleado("Federico", "Mizzau", "mail4@gmail.com", 3510000004, EncargadoDeInstalaciones);


        // Usuario (string nombreUsuario, string contrasena, Empleado empleado)
        public static Usuario Usuario1 { get; set; } = new Usuario("germanvelez", "0001", Empleado1);
        public static Usuario Usuario2 { get; set; } = new Usuario("marcelacattaneo", "0002", Empleado2);
        public static Usuario Usuario3 { get; set; } = new Usuario("salvadorbarbera", "0003", Empleado3);
        public static Usuario Usuario4 { get; set; } = new Usuario("federicomizzau", "0004", Empleado4);


        // Sesión actual
        public static DateTime fechaInicio = DateTime.Now;
        public static DateTime fechaFin = DateTime.Now.AddHours(2);
        public static Sesion sesionActual = new Sesion(fechaFin, fechaInicio, Usuario1);
        public static Sesion loadSesion() { return sesionActual; }


        // Estacion sismológica (int codigoEstacion, bool documentoCertificacionAdquirido, int latitud, int longitud, string nombre, int nroCertificacionAdquisicion)
        public static EstacionSismologica Estacion1 { get; set; } = new EstacionSismologica(1, true, 000000001, 000000001, "Estacion1", 000000001);
        public static EstacionSismologica Estacion2 { get; set; } = new EstacionSismologica(2, true, 000000002, 000000002, "Estacion2", 000000002);
        public static EstacionSismologica Estacion3 { get; set; } = new EstacionSismologica(3, true, 000000003, 000000003, "Estacion3", 000000003);


        // Estados de la OI (string nombre) [¿No tendría que ser un objeto Estado y tener el atributo ambito = OrdenDeInspeccion?]
        public static EstadoOI Cerrada { get; set; } = new EstadoOI("Cerrada");
        public static EstadoOI ParcialmenteRealizada { get; set; } = new EstadoOI("ParcialmenteRealizada");
        public static EstadoOI PendienteDeRealizacion { get; set; } = new EstadoOI("PendienteDeRealizacion");
        public static EstadoOI CompletamenteRealizada { get; set; } = new EstadoOI("CompletamenteRealizada");


        // REVISAR EN EL DOMINIO LAS FECHAS

        // ATRIBUTO              |    ¿CUÁNDO SE ASIGNA?	
        // fechaHoraInicio       |    Al iniciar la inspección (Iniciar inspección de ES)
        // fechaHoraFinalizacion |    Cuando se completan todas las tareas de la orden
        // fechaHoraCierre       |    Cuando se cierra la orden de inspección (Cierre de OI)

        // Orden de inspección (Empleado empleado, EstacionSismologica estacionSismologica, EstadoOI estadoOI, DateTime fechaHoraCierre, DateTime fechaHoraInicio, DateTime fechaHoraFinalizacion, int numeroOrden, string observacionCierre)
        public static OrdenDeInspeccion Orden1 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion1, CompletamenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 1, "Observacion1");
        public static OrdenDeInspeccion Orden2 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, CompletamenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 2, "Observacion6");
        public static OrdenDeInspeccion Orden3 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, CompletamenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 3, "Observacion7");
        public static OrdenDeInspeccion Orden4 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, CompletamenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 4, "Observacion8");
        public static OrdenDeInspeccion Orden5 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, Cerrada, new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), new DateTime(2025, 4, 5), 5, "Observacion2");
        public static OrdenDeInspeccion Orden6 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion3, Cerrada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 6, "Observacion3");
        public static OrdenDeInspeccion Orden7 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, ParcialmenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 7, "Observacion4");
        public static OrdenDeInspeccion Orden8 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion2, ParcialmenteRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 8, "Observacion5");


        // Listas de ordenes para que el gestor las recorra
        public static List<OrdenDeInspeccion> loadOrdenesDeInspeccion() {     
            List<OrdenDeInspeccion> ordenes = new List<OrdenDeInspeccion>();
            ordenes.Add(Orden1);
            ordenes.Add(Orden2);
            ordenes.Add(Orden3);
            ordenes.Add(Orden4);
            ordenes.Add(Orden5);
            ordenes.Add(Orden6);
            ordenes.Add(Orden7);
            ordenes.Add(Orden8);
            return ordenes;
        }
        

        // Estados del sismógrafo (string nombre)
        public static EstadoSismografo EnEsperaDeCertificacion { get; set; } = new EstadoSismografo("EnEsperaDeCertificacion");
        public static EstadoSismografo EnInstalacion{ get; set; } = new EstadoSismografo("EnInstalacion");
        public static EstadoSismografo EnLinea { get; set; } = new EstadoSismografo("EnLinea");
        public static EstadoSismografo DeBaja { get; set; } = new EstadoSismografo("DeBaja");
        public static EstadoSismografo Disponible { get; set; } = new EstadoSismografo("Disponible");
        public static EstadoSismografo FueraDeServicio { get; set; } = new EstadoSismografo("FueraDeServicio");
        public static EstadoSismografo HabilitadoASerIncluido{ get; set; } = new EstadoSismografo("HabilitadoASerIncluido");
        public static EstadoSismografo IncluidoEnPlanDeConstruccion{ get; set; } = new EstadoSismografo("IncluidoEnPlanDeConstruccion");
        public static EstadoSismografo InhabilitadoPorInspeccion { get; set; } = new EstadoSismografo("InhabilitadoPorInspeccion");
        public static EstadoSismografo Reclamado { get; set; } = new EstadoSismografo("Reclamado");
        

        // Cambio de estado del sismógrafo (DateTime? fechaHoraFin, DateTime? fechaHoraInicio, EstadoSismografo estadoSismografo)
        public static CambioEstadoSismografo CESismografo1 = new CambioEstadoSismografo(null, new DateTime(2025, 5, 5), InhabilitadoPorInspeccion);
        public static CambioEstadoSismografo CESismografo2 = new CambioEstadoSismografo(new DateTime(2025, 5, 5), new DateTime(2025, 4, 5), EnLinea);
        public static CambioEstadoSismografo CESismografo3 = new CambioEstadoSismografo(new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), EnInstalacion);


        // Lista de cambios de estado para el sismógrafo
        public static List<CambioEstadoSismografo> loadCambiosDeEstadoSismografo()
        {
            List<CambioEstadoSismografo> listaCambiosEstadoSismografo = new List<CambioEstadoSismografo>();
            listaCambiosEstadoSismografo.Add(CESismografo1);
            listaCambiosEstadoSismografo.Add(CESismografo2);
            listaCambiosEstadoSismografo.Add(CESismografo3);
            return listaCambiosEstadoSismografo;
        }


        // Sismógrafos (a todos les puse los mismos cambios de estado, pero se pueden poner diferentes)
        public static Sismografo Sismografo1 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 1, 1001, loadCESismografo(), Estacion1);
        public static Sismografo Sismografo2 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 2, 1002, loadCESismografo(), Estacion2);
        public static Sismografo Sismografo3 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 3, 1003, loadCESismografo(), Estacion3);
    

        // Lista de sismógrafos para cargar en el gestor
        public static List<Sismografo> loadSismografos()
        {
            List<Sismografo> listaSismografos = new List<Sismografo>();
            listaSismografos.Add(Sismografo1);
            listaSismografos.Add(Sismografo2);
            listaSismografos.Add(Sismografo3);
            return listaSismografos;
        }
    }
}
