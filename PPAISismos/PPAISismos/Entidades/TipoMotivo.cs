using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class TipoMotivo
    {
        // Atributos
        private string descripcion;

        // Métodos
        public TipoMotivo(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
    }
}