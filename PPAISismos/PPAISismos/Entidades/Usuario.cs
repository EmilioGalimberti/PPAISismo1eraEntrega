using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class Usuario
    {
        private string nombreUsuario { get; set; }
        private string contrasena { get; set; }
        //Usuario -> 1 Empleado
        private Empleado empleado { get; set; }

        public Usuario(string nombreUsuario, string contrasena, Empleado empleado)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.empleado = empleado;
        }
    }
}
