using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class MotivoFueraServicio
    {
        private string tipoMotivo;
        private string comentario;

        public MotivoFueraServicio(string tipoMotivo, string comentario)
        {
            this.tipoMotivo = tipoMotivo;
            this.comentario = comentario;
        }
    }
} 