using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class Rol
    {
        private string nombre { get; set; }
        private string descripcionRol { get; set; }

        public Rol(string nombre, string descripcionRol)
        {
            this.nombre = nombre;
            this.descripcionRol = descripcionRol;
        }

        public bool esResponsable() { return nombre == "ResponsableEnReparacion"; }

    }
}
