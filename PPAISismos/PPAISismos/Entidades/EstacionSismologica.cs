using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class EstacionSismologica
    {
        //Atributos
        private int codigoEstacion;
        private bool documentoCerificacionAdquirido;
        private int latitud;
        private int longitud;
        private string nombre;
        private int nroCerficicacionAdquisicion;
        private DateTime fechaSolicitudCertificacion;

        public EstacionSismologica(int codigoEstacion, bool documentoCerificacionAdquirido, int latitud, int longitud, string nombre, int nroCerficicacionAdquisicion, DateTime fechaSolicitudCertificacion)
        {
            this.codigoEstacion = codigoEstacion;
            this.documentoCerificacionAdquirido = documentoCerificacionAdquirido;
            this.latitud = latitud;
            this.longitud = longitud;
            this.nombre = nombre;
            this.nroCerficicacionAdquisicion = nroCerficicacionAdquisicion;
            this.fechaSolicitudCertificacion = fechaSolicitudCertificacion;
            this.fechaSolicitudCertificacion = fechaSolicitudCertificacion;
        }

        public string getNombre()
        {
            return nombre;
        }

    }
}
