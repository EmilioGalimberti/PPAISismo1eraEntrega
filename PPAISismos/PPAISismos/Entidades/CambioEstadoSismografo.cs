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
        //CambioEstadoSismografo -> 0..* MotivoFueraServicio
        private List<MotivoFueraServicio> motivosFueraServicio;

        public CambioEstadoSismografo(DateTime? fechaHoraFin, DateTime fechaHoraInicio, EstadoSismografo estadoSismografo)
        {
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.estadoSismografo = estadoSismografo;
            this.motivosFueraServicio = new List<MotivoFueraServicio>(); // Siempre inicializada pero vacia
        }

        public bool esActual()
        {
            if (fechaHoraFin == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setFehaFin(DateTime fechaHoraActual)
        {
            this.fechaHoraFin = fechaHoraActual;
        }

        public void crearMotivosFueraServicio(List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios)
        {
            if (motivosSeleccionadosConComentarios == null)
                return;

            foreach (var (motivoTipo, comentario) in motivosSeleccionadosConComentarios)
            {
                var motivoFueraServicio = new MotivoFueraServicio(comentario, motivoTipo);
                motivosFueraServicio.Add(motivoFueraServicio);
            }
        }


        //ESTO ES SOLO PARA PROBAR
        public DateTime? getFechaHoraFin() => fechaHoraFin;
        public DateTime getFechaHoraInicio() => fechaHoraInicio;
        public EstadoSismografo getEstadoSismografo() => estadoSismografo;
        public List<MotivoFueraServicio> getMotivosFueraServicio() => motivosFueraServicio;
    }
}
