using PPAISismos.Entidades;
using PPAISismos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Data
{
    public class Data
    {
        // Objetos :Rol
        // (string nombre, string descripcion)
        public static Rol ResponsableDeInspecciones { get; set; } = new Rol("Responsable de Inspecciones", "Descripcion 1");
        public static Rol AnalistaEnSismos { get; set; } = new Rol("Analista en Sismos", "Descripción 2");
        public static Rol AnalistaSupervisor { get; set; } = new Rol("Analista Supervisor", "Descripción 3");
        public static Rol EncargadoDeInstalaciones { get; set; } = new Rol("Encargado de Instalaciones", "Descripción 4");
        public static Rol ResponsableDeReparaciones { get; set; } = new Rol("Responsable de Reparaciones", "Descripción 5");


        // Objetos :Empleado
        // (string nombre, string apellido, string mail, int telefono, Rol rol)        
        public static Empleado Empleado1 { get; set; } = new Empleado("Germán", "Vélez", "german.velez@gmail.com", 3891234 , ResponsableDeInspecciones);
        public static Empleado Empleado2 { get; set; } = new Empleado("Marcela", "Cattaneo", "marcela.cattaneo@gmail.com", 3891234, ResponsableDeInspecciones);
        public static Empleado Empleado3 { get; set; } = new Empleado("Salvador", "Barbera", "salvador.barbera@gmail.com", 3891234, AnalistaSupervisor);
        public static Empleado Empleado4 { get; set; } = new Empleado("Federico", "Mizzau", "federico.mizzau@gmail.com", 3891234, ResponsableDeReparaciones);
        public static Empleado Empleado5 { get; set; } = new Empleado("Arturo", "Illia", "arturo.illia5@gmail.com", 3891234, ResponsableDeReparaciones);


        // Objetos :Usuario
        // (string nombreUsuario, string contrasena, Empleado empleado)
        public static List<Empleado> loadEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(Empleado1);
            listaEmpleados.Add(Empleado2);
            listaEmpleados.Add(Empleado3);
            listaEmpleados.Add(Empleado4);
            listaEmpleados.Add(Empleado5);
            return listaEmpleados;
        }


        // Objetos :Usuario
        // (string nombreUsuario, string contrasena, Empleado empleado)
        public static Usuario Usuario1 { get; set; } = new Usuario("germanvelez", "0001", Empleado1);
        public static Usuario Usuario2 { get; set; } = new Usuario("marcelacattaneo", "0002", Empleado2);
        public static Usuario Usuario3 { get; set; } = new Usuario("salvadorbarbera", "0003", Empleado3);
        public static Usuario Usuario4 { get; set; } = new Usuario("federicomizzau", "0004", Empleado4);


        // Inicialización de objeto actual:Sesion
        public static DateTime fechaInicio = DateTime.Now;
        public static DateTime fechaFin = DateTime.Now.AddHours(2);
        public static Sesion sesionActual = new Sesion(fechaFin, fechaInicio, Usuario1);
        public static Sesion loadSesion() { return sesionActual; }


        // Objetos :EstacionSismologica
        // (int codigoEstacion, bool documentoCertificacionAdquirido, int latitud, int longitud, string nombre, int nroCertificacionAdquisicion)
        public static EstacionSismologica Estacion1 { get; set; } = new EstacionSismologica(1, true, 000000001, 000000001, "Estacion1", 000000001);
        public static EstacionSismologica Estacion2 { get; set; } = new EstacionSismologica(2, true, 000000002, 000000002, "Estacion2", 000000002);
        public static EstacionSismologica Estacion3 { get; set; } = new EstacionSismologica(3, true, 000000003, 000000003, "Estacion3", 000000003);


        // Objetos :EstadoOI
        // (string nombre)
        public static EstadoOI EstadoOIRealizada { get; set; } = new EstadoOI("Realizada");
        public static EstadoOI EstadoOICerrada { get; set; } = new EstadoOI("Cerrada");
        public static EstadoOI EstadoOIPendienteDeRealizacion { get; set; } = new EstadoOI("PendienteDeRealizacion");
        public static EstadoOI EstadoOIParcialmenteRealizada { get; set; } = new EstadoOI("ParcialmenteRealizada");

        // Lista de objetos :EstadoOI
        public static List<EstadoOI> loadListaEstadoOI()
        {
            List<EstadoOI> listaEstadoOI = new List<EstadoOI>();
            listaEstadoOI.Add(EstadoOIRealizada);
            listaEstadoOI.Add(EstadoOICerrada);
            listaEstadoOI.Add(EstadoOIPendienteDeRealizacion);
            listaEstadoOI.Add(EstadoOIParcialmenteRealizada);
            return listaEstadoOI;
        }


        // Objetos :OrdenDeInspeccion
        // (Empleado empleado, EstacionSismologica estacionSismologica, EstadoOI estadoOI, DateTime fechaHoraCierre, DateTime fechaHoraInicio, DateTime fechaHoraFinalizacion, int numeroOrden, string observacionCierre)
        public static OrdenDeInspeccion Orden1 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion1, EstadoOIRealizada,null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 1, null);
        public static OrdenDeInspeccion Orden2 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, EstadoOIRealizada, null , new DateTime(2025, 4, 5), new DateTime(2025, 6, 6), 2, null);
        public static OrdenDeInspeccion Orden3 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoOIRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 3, null);
        public static OrdenDeInspeccion Orden4 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoOIRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 4, null);
        public static OrdenDeInspeccion Orden5 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion2, EstadoOICerrada, new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), new DateTime(2025, 4, 5), 5, "Observacion2");
        public static OrdenDeInspeccion Orden6 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion3, EstadoOICerrada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 6, "Observacion3");
        public static OrdenDeInspeccion Orden7 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion1, EstadoOICerrada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 7, "Observacion4");
        public static OrdenDeInspeccion Orden8 { get; set; } = new OrdenDeInspeccion(Empleado2, Estacion2, EstadoOICerrada, null, new DateTime(2025, 4, 5), new DateTime(2025, 5, 5), 8, "Observacion5");
        public static OrdenDeInspeccion Orden9 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion1, EstadoOIRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), 9, null);
        public static OrdenDeInspeccion Orden10 { get; set; } = new OrdenDeInspeccion(Empleado1, Estacion3, EstadoOIRealizada, null, new DateTime(2025, 4, 5), new DateTime(2025, 9, 5), 10, null);

        // Lista de objetos :OrdenDeInspeccion
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
            ordenes.Add(Orden9);
            ordenes.Add(Orden10);
            return ordenes;
        }


        // Objetos :EstadoSismografo
        // (string nombre)
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

        // Lista de objetos :EstadoSismografo
        public static List<EstadoSismografo> loadListaEstadoSismografo()
        {
            List<EstadoSismografo> listaEstadoSismografo = new List<EstadoSismografo>();
            listaEstadoSismografo.Add(EnEsperaDeCertificacion);
            listaEstadoSismografo.Add(EnInstalacion);
            listaEstadoSismografo.Add(EnLinea);
            listaEstadoSismografo.Add(DeBaja);
            listaEstadoSismografo.Add(Disponible);
            listaEstadoSismografo.Add(FueraDeServicio);
            listaEstadoSismografo.Add(HabilitadoASerIncluido);
            listaEstadoSismografo.Add(IncluidoEnPlanDeConstruccion);
            listaEstadoSismografo.Add(InhabilitadoPorInspeccion);
            listaEstadoSismografo.Add(Reclamado);
            return listaEstadoSismografo;
        }


        // Objetos :CambioEstadoSismografo
        // (DateTime? fechaHoraFin, DateTime? fechaHoraInicio, EstadoSismografo estadoSismografo)
        public static CambioEstadoSismografo ce1 = new CambioEstadoSismografo(null, new DateTime(2025, 5, 5), InhabilitadoPorInspeccion, Empleado1);
        public static CambioEstadoSismografo ce2 = new CambioEstadoSismografo(new DateTime(2025, 5, 5), new DateTime(2025, 4, 5), EnLinea, Empleado1);
        public static CambioEstadoSismografo ce3 = new CambioEstadoSismografo(new DateTime(2025, 4, 5), new DateTime(2025, 3, 5), EnInstalacion, Empleado1);

        // Lista de objetos :CambioEstadoSismografo
        public static List<CambioEstadoSismografo> loadCambioEstadoSismografo()
        {
            List<CambioEstadoSismografo> listaCE = new List<CambioEstadoSismografo>();
            listaCE.Add(ce1);
            listaCE.Add(ce2);
            listaCE.Add(ce3);
            return listaCE;
        }


        // Objetos :Sismografo
        // (DateTime fechaInstalacion, int id, int nroSerie, List<CambioEstadoSismografo> listaCambioEstadoSismografo, EstacionSismologica estacionSismologica)
        public static Sismografo Sismografo1 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 1, 1001, loadCambioEstadoSismografo(), Estacion1);
        public static Sismografo Sismografo2 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 2, 1002, loadCambioEstadoSismografo(), Estacion2);
        public static Sismografo Sismografo3 { get; set; } = new Sismografo(new DateTime(2022, 4, 5), 3, 1003, loadCambioEstadoSismografo(), Estacion3);


        // Lista de objetos :Sismografo
        public static List<Sismografo> loadSismografos()
        {
            List<Sismografo> listaSismografos = new List<Sismografo>();
            listaSismografos.Add(Sismografo1);
            listaSismografos.Add(Sismografo2);
            listaSismografos.Add(Sismografo3);
            return listaSismografos;
        }


        // Objetos :MotivoTipo
        // (string nombre)
        public static MotivoTipo tipoMotivoAveríaPorVibracion { get; set; } = new MotivoTipo("Averia por vibracion");
        public static MotivoTipo tipoMotivoDesgasteDeComponente { get; set; } = new MotivoTipo("Desgaste de componente");
        public static MotivoTipo tipoMotivoFalloEnElSistemadeRegistro { get; set; } = new MotivoTipo("Fallo en el sistema de registro");
        public static MotivoTipo tipoMotivoVandalismo { get; set; } = new MotivoTipo("Vandalismo");
        public static MotivoTipo tipoMotivoFalloEnLaFuenteDeAlimentacion { get; set; } = new MotivoTipo("Fallo en la fuente de alimentacion");

        // Lista de objetos :MotivoTipo
        public static List<MotivoTipo> loadMotivosTipos()
        {
            List<MotivoTipo> listaMotivos = new List<MotivoTipo>();
            listaMotivos.Add(tipoMotivoAveríaPorVibracion);
            listaMotivos.Add(tipoMotivoDesgasteDeComponente);
            listaMotivos.Add(tipoMotivoFalloEnElSistemadeRegistro);
            listaMotivos.Add(tipoMotivoVandalismo);
            listaMotivos.Add(tipoMotivoFalloEnLaFuenteDeAlimentacion);
            return listaMotivos;
        }


        // Inicialización de objeto :InterfazMail
        public static InterfazMail InterfazMail { get; set; } = new InterfazMail();
        public static InterfazMail loadInterfazMail()
        {
            return InterfazMail;
        }


        // Objetos :Monitor
        public static Monitor Monitor1 { get; set; } = new Monitor();
        public static Monitor Monitor2 { get; set; } = new Monitor();
        public static Monitor Monitor3 { get; set; } = new Monitor();
        public static Monitor Monitor4 { get; set; } = new Monitor();
        public static Monitor Monitor5 { get; set; } = new Monitor();

        // Lista de objetos :Monitor
        public static List<Monitor> loadListaMonitores()
        {
            List<Monitor> listaMonitores = new List<Monitor>();
            listaMonitores.Add(Monitor1);
            listaMonitores.Add(Monitor2);
            listaMonitores.Add(Monitor3);
            listaMonitores.Add(Monitor4);
            listaMonitores.Add(Monitor5);
            return listaMonitores;
        }
    }
}
