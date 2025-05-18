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

        //Solo para probar las ordenes
        public int getNumeroOrden()
        {
            return numeroOrden;       
        }

        //Para saber si tiene el puntero al empleado logueado
        public bool esDeEmpleado(Empleado empleadoLogueado)
        {
            return empleado == empleadoLogueado;
        }

        //Revisar que se llame igual que en el diagrama de secuencia
        public bool verificarOIRealizada()
        {
           return estadoOI.esRealizada();
        }

        //para obtener el puntero a la ES
        public EstacionSismologica obtenerES()
        {
            return estacionSismologica;
        }

    }
}
