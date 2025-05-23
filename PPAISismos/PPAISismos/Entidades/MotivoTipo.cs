using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class MotivoTipo
    {
        string descipcion;

        public MotivoTipo(string descripcion)
        {
            this.descipcion = descripcion;
        }

        public string getDescripcion()
        {
            return descipcion;
        }
    }
   
}
