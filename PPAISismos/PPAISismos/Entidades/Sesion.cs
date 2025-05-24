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
        private Usuario usuarioLogueado;

        //METODOS

        // --> Metodo Constructor
        public Sesion(DateTime fechaFin, DateTime fechaInicio, Usuario usuarioActual)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.usuarioLogueado = usuarioActual;
        }

        //--> Obtener el Empleado logueado
        public Empleado getUsuario()
        {
            return usuarioLogueado.getEmpleado();
        }
    }
}

