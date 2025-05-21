using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class Sismografo
    {
        private DateTime fechaAdquisicion;
        private int identificadoSismografo;
        private int nroSerie;
        //por ahora no le pongo una relacion directa del sismografo al estadoActual porque creo que no la usamos
        //Sismografo -> 1..* CambioEstadoSismografo
        private List<CambioEstadoSismografo> listaCambioEstadoSismografo;
        //Sismografo -> 1 EstacionSismologica
        private EstacionSismologica estacionSismologica;

        public Sismografo(DateTime fechaAdquisicion, int identificadoSismografo, int nroSerie , List<CambioEstadoSismografo> listaCambioEstadoSismografo, EstacionSismologica estacionSismologica)
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.identificadoSismografo = identificadoSismografo;
            this.nroSerie = nroSerie;
            this.listaCambioEstadoSismografo = listaCambioEstadoSismografo;
            this.estacionSismologica = estacionSismologica;
        }

        public bool esTuES(EstacionSismologica estacionSismologicaOI) { return estacionSismologicaOI == estacionSismologica; }

        public int getIdentificador() { return identificadoSismografo; }

        private CambioEstadoSismografo buscarCambioEstadoActual()
        {
            foreach (CambioEstadoSismografo cambioEstado in listaCambioEstadoSismografo)
            {
                if (cambioEstado.esActual())
                {
                    return cambioEstado;
                }
            }
            return null;
        }

        private void cerrarCambioEstado(DateTime fechaHoraActual)
        {
            CambioEstadoSismografo cambioEstadoActual = buscarCambioEstadoActual();
            if (cambioEstadoActual != null)
            {
                cambioEstadoActual.setFechaHoraFin(fechaHoraActual);
            }
        }

        public void ponerFueraServicio(EstadoSismografo estadoFueraServicio, DateTime fechaHoraActual, List<(string tipoMotivo, string comentario)> tiposMotivoYComentarios)
        {
            cerrarCambioEstado(fechaHoraActual);
            CambioEstadoSismografo nuevoCambioEstado = new CambioEstadoSismografo(null, fechaHoraActual, estadoFueraServicio);
            foreach (var (tipoMotivo, comentario) in tiposMotivoYComentarios)
            {
                nuevoCambioEstado.crearMotivoFueraServicio(tipoMotivo, comentario);
            }
            listaCambioEstadoSismografo.Add(nuevoCambioEstado);
        }
    }
}
