using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class CambioEstadoSismografo
    {
        //Atributos
        private DateTime? fechaHoraFin;
        private DateTime fechaHoraInicio;
        //CambioEstadoSismografo -> 1 EstadoSismografo
        EstadoSismografo estadoSismografo;

        public CambioEstadoSismografo(DateTime? fechaHoraFin, DateTime fechaHoraInicio, EstadoSismografo estadoSismografo)
        {
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.estadoSismografo = estadoSismografo;
        }
    }
}
