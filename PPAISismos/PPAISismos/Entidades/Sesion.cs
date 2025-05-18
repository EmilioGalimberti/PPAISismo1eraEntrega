using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class Sesion
    {
        //ATRIBUTOS
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private Usuario usuarioActual;

        //METODOS

        // --> Metodo Constructor
        public Sesion(DateTime fechaFin, DateTime fechaInicio, Usuario usuarioActual)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.usuarioActual = usuarioActual;
        }

        //--> Obtener el Empleado logueado
        //public PersonalCientifico verificarCientificoLogueado() { return usuarioActual.obtenerCientifico(); }
    }
}

