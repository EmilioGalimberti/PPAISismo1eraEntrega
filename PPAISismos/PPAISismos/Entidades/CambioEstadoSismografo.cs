using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAISismos.Entidades;

namespace PPAISismos.Entidades
{
    public class CambioEstadoSismografo
    {
        //Atributos
        private DateTime? fechaHoraFin;
        private DateTime fechaHoraInicio;
        //CambioEstadoSismografo -> 1 EstadoSismografo
        EstadoSismografo estadoSismografo;
        //CambioEstadoSismografo -> * MotivoFueraServicio
        private List<MotivoFueraServicio> motivosFueraServicio;

        public CambioEstadoSismografo(DateTime? fechaHoraFin, DateTime fechaHoraInicio, EstadoSismografo estadoSismografo)
        {
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.estadoSismografo = estadoSismografo;
            this.motivosFueraServicio = new List<MotivoFueraServicio>();
        }

        public bool esActual()
        {
            return fechaHoraFin == null;
        }

        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            this.fechaHoraFin = fechaHoraFin;
        }

        public void crearMotivoFueraServicio(string tipoMotivo, string comentario)
        {
            MotivoFueraServicio motivo = new MotivoFueraServicio(tipoMotivo, comentario);
            motivosFueraServicio.Add(motivo);
        }
    }
}
