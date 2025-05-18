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
        //Roles (nombre, descripcion)
        public static Rol ResponsableDeReparacion { get; set; } = new Rol("ResponsableEnReparacion", "descripcion");
        //buscar en el dominio mas roles este es solo de prueba:
        public static Rol ResponsableEnNada { get; set; } = new Rol("ResponsableEnNada", "descripcion2");
        
        
        //Clientes (nombre, apellido, mail, telefono, rol)
        public static Empleado Empleado1 { get; set; } = new Empleado("Juan", "Lopez", "mail@gmail.com", 123456789, ResponsableDeReparacion);
        public static Empleado Empleado2 { get; set; } = new Empleado("Pedro", "Picapiedra", "mail2@gmail.com", 803456789, ResponsableDeReparacion);
        public static Empleado Empleado3 { get; set; } = new Empleado("Pablo", "ASD", "mail3@gmail.com", 803456789, ResponsableEnNada);

        //Usuario (string nombreUsuario, string contrasena, Empleado empleado)
        public static Usuario Usuario1 { get; set; } = new Usuario("Juanito", "1234", Empleado1);
        public static Usuario Usuario2 { get; set; } = new Usuario("Pedrito", "1234", Empleado2);
        public static Usuario Usuario3 { get; set; } = new Usuario("Pablito", "1234", Empleado3);

        //Sesion actual
        public static DateTime fechaInicio = DateTime.Now;
        public static DateTime fechaFin = DateTime.Now.AddHours(2);
        public static Sesion sesionActual = new Sesion(fechaFin, fechaInicio, Usuario1);

        public static Sesion loadSesion() { return sesionActual; }


        //Estacion Sismologica (int codigoEstacion, bool documentoCerificacionAdquirido, int latitud, int longitud, string nombre, int nroCerficicacionAdquisicion)
        public static EstacionSismologica Estacion1 { get; set; } = new EstacionSismologica(1, true, 123456789, 123456789, "Estacion1", 123456789);
        public static EstacionSismologica Estacion2 { get; set; } = new EstacionSismologica(2, true, 123456789, 123456789, "Estacion2", 123456789);
        public static EstacionSismologica Estacion3 { get; set; } = new EstacionSismologica(3, true, 123456789, 123456789, "Estacion3", 123456789);

        //EstadoOI FALTA BUSCAR EL RESTO DE LOS ESTADOS DE LA OI
        public static EstadoOI EstadoRealizada { get; set; } = new EstadoOI("Realizada");
        public static EstadoOI EstadoCerrada { get; set; } = new EstadoOI("Cerrada");
        public static EstadoOI EstadoPendienteDeRealizacion { get; set; } = new EstadoOI("PendienteDeRealizacion");
        public static EstadoOI EstadoParcialmenteRealizada { get; set; } = new EstadoOI("ParcialmenteRealizada");
        public static EstadoOI EstadoCompletamenteFinalizada { get; set; } = new EstadoOI("CompletamenteFinalizada");
        //Buscar mas estados en el dominio, este es de prueba:
        public static EstadoOI EstadoNada { get; set; } = new EstadoOI("Nada");
        
        


        //REVISAR EL DOMINIO SOBRE LAS FECHAS, 
        //Atributo	           |¿Cuándo se asigna?	
        //fechaHoraInicio      | Al iniciar la inspección(Iniciar inspección de ES)
        //fechaHoraFinalizacion| Cuando se completan todas las tareas de la orden
        //fechaHoraCierre      | Cuando se cierra la orden de inspección (Cierre de OI)
        //OrdenDeInspeccion(Empleado empleado,EstacionSismologica estacionSismologica,EstadoOI estadoOI,DateTime fechaHoraCierre,DateTime fechaHoraInicio,DateTime fechaHoraFinalizacion,int numeroOrden,string observacionCierre)
        public static OrdenDeInspeccion Orden1 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion1, EstadoRealizada,null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 1, "Observacion1");
        public static OrdenDeInspeccion Orden2 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, EstadoRealizada, null , new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 2, "Observacion6");
        public static OrdenDeInspeccion Orden3 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 3, "Observacion7");
        public static OrdenDeInspeccion Orden4 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 4, "Observacion8");
        public static OrdenDeInspeccion Orden5 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, EstadoCerrada, new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), new DateTime(2025, 4, 5), 5, "Observacion2");
        public static OrdenDeInspeccion Orden6 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion3, EstadoNada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 6, "Observacion3");
        public static OrdenDeInspeccion Orden7 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoNada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 7, "Observacion4");
        public static OrdenDeInspeccion Orden8 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion2, EstadoNada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 8, "Observacion5");

        //Listas de ordenes para que el gestor las recorra
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

        //EstadoSismografo, 
        public static EstadoSismografo EstadoFueraDeServicio { get; set; } = new EstadoSismografo("FueraDeServicio");
        public static EstadoSismografo EstadoEnLinea { get; set; } = new EstadoSismografo("EnLinea");
        public static EstadoSismografo EstadoInhabilitadoPorInspeccion { get; set; } = new EstadoSismografo("InhabilitadoPorInspeccion");
        public static EstadoSismografo EstadoEnInstalacion{ get; set; } = new EstadoSismografo("EnInstalacion");
        public static EstadoSismografo EstadoReclamado{ get; set; } = new EstadoSismografo("Reclamado");
        public static EstadoSismografo EstadoDeBaja{ get; set; } = new EstadoSismografo("DeBaja");
        public static EstadoSismografo EstadoIncluidoEnPlanDeConstruccion{ get; set; } = new EstadoSismografo("IncluidoEnPlanDeConstruccion");
        public static EstadoSismografo EstadoHabilitadoASerIncluido{ get; set; } = new EstadoSismografo("HabilitadoASerIncluido");
        public static EstadoSismografo EstadoDisponible{ get; set; } = new EstadoSismografo("Disponible");
        public static EstadoSismografo EstadoEnEsperaDeCertificacion{ get; set; } = new EstadoSismografo("EnEsperaDeCertificacion");

        //Cambio de estado sismografos
        //      DateTime? fechaHoraFin, DateTime? fechaHoraInicio, EstadoSismografo estadoSismografo)

        public static CambioEstadoSismografo ce1 = new CambioEstadoSismografo(null, new DateTime(2025, 5, 5), EstadoInhabilitadoPorInspeccion);
        public static CambioEstadoSismografo ce2 = new CambioEstadoSismografo(new DateTime(2025, 5, 5), new DateTime(2025, 4, 5), EstadoEnLinea);
        public static CambioEstadoSismografo ce3 = new CambioEstadoSismografo(new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), EstadoEnInstalacion);

        //Listas de cambio de estados para el sismografo
        public static List<CambioEstadoSismografo> loadCambioEstadoSismografo()
        {
            List<CambioEstadoSismografo> listaCE = new List<CambioEstadoSismografo>();
            listaCE.Add(ce1);
            listaCE.Add(ce2);
            listaCE.Add(ce3);
            return listaCE;
        }

        //SISMOGRAFOS (a todos les puse los mismos cambio de estados, se puede poner diferentes
        public static Sismografo Sismografo1 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 1, 1001, loadCambioEstadoSismografo(), Estacion1);
        public static Sismografo Sismografo2 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 2, 1002, loadCambioEstadoSismografo(), Estacion2);
        public static Sismografo Sismografo3 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 3, 1003, loadCambioEstadoSismografo(), Estacion3);
    
        //Lista de sismografos para cargar en el gestor
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
