using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class OrdenDeInspeccion
    {
        //Atributos
        //OI->1 Empleado
        private Empleado empleado;
        //OI->1 EstacionSimologica
        private EstacionSismologica estacionSismologica;
        //OI->1 EstadoOI
        private EstadoOI estadoOI;

        private DateTime? fechaHoraCierre;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFinalizacion;
        private int numeroOrden;
        private string observacionCierre;

        //Constructor
        public OrdenDeInspeccion(Empleado empleado,EstacionSismologica estacionSismologica,EstadoOI estadoOI,DateTime? fechaHoraCierre,DateTime fechaHoraInicio,DateTime fechaHoraFinalizacion,int numeroOrden,string observacionCierre)
        {
            this.empleado = empleado;
            this.estacionSismologica = estacionSismologica;
            this.estadoOI = estadoOI;
            this.fechaHoraCierre = fechaHoraCierre;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFinalizacion = fechaHoraFinalizacion;
            this.numeroOrden = numeroOrden;
            this.observacionCierre = observacionCierre;
        }
        public int getNumeroOrden()
        {
            return numeroOrden;       
        }
        public DateTime getFechaFinalizacion()
        {
            return fechaHoraFinalizacion;
        }

        //Para saber si tiene el puntero al empleado logueado
        public bool esDeEmpleado(Empleado empleadoLogueado)
        {
            return empleado == empleadoLogueado;
        }
        public bool verificarOIRealizada()
        {
           return estadoOI.esRealizada();
        }

        //para obtener el puntero a la ES
        public EstacionSismologica obtenerES()
        {
            return estacionSismologica;
        }

        public string getNombreES()
        {
            return estacionSismologica.getNombre();
        }

        //ACA DEBERIA SER CON SETERS EN VERDAD PERO PREGUNTAR SI LO DEJO ASI O LOS AGREGO Y SI LOS TENDRIA QUE AGREGAR EN EL DIAGRAMA DE SECUENCIA
        public void cerrarOI(EstadoOI estadoCerrada,DateTime fechaHoraCierre, string observacion)
        {
            this.fechaHoraCierre = fechaHoraCierre;
            this.estadoOI = estadoCerrada;
            this.observacionCierre = observacion;
        }





        //ESTO ES SOLO PARA PROBAR QUE CAMBIE BIEN EL ESTADO AL CERRAR LA OI 
        //COMENTAR ESTOS METODOS
        public string getNombreEstadoOI()
        {
            return estadoOI != null ? estadoOI.getNombre() : null;
        }
        public DateTime? getFechaHoraCierre() => fechaHoraCierre;
        public string getObservacionCierre() => observacionCierre;
    }


}
