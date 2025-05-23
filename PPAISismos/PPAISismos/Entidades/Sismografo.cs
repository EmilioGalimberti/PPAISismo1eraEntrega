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

        public void ponerSismografoFueraServicio(EstadoSismografo estadoSismografo, DateTime fechaHoraActual, List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios, Empleado empleadoLogueado)
        {
           CambioEstadoSismografo cambioEstadoActual = buscarCambioEstadoActual();
            if(cambioEstadoActual != null)
            {
                cambioEstadoActual.setFehaFin(fechaHoraActual);

                // Crear el nuevo cambio de estado actual
                var nuevoCambioEstado = new CambioEstadoSismografo(
                    null,                // fechaHoraFin (es actual, así que no tiene fin)
                    fechaHoraActual,     // fechaHoraInicio
                    estadoSismografo,     // nuevo estado
                    empleadoLogueado
                );
                // Crear y asociar los motivos fuera de servicio
                nuevoCambioEstado.crearMotivosFueraServicio(motivosSeleccionadosConComentarios);


                // Agregarlo a la lista
                listaCambioEstadoSismografo.Add(nuevoCambioEstado);
            }
        }

        public CambioEstadoSismografo buscarCambioEstadoActual()
        {
            foreach(var cambioEstado in listaCambioEstadoSismografo)
            {
                if (cambioEstado.esActual())
                {
                    return cambioEstado;
                   
                   
                }

            }
            return null;
        }


        //ESTO ES SOLO PARA PROBAR
        public List<CambioEstadoSismografo> getListaCambioEstadoSismografo()
        {
            return listaCambioEstadoSismografo;
        }
    }
}
