using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAISismos.Entidades
{
    public class MotivoFueraServicio
    {
        string comentario;
        MotivoTipo motivoTipo;

        public MotivoFueraServicio(string comentario, MotivoTipo motivoTipo)
        {
            this.comentario = comentario;
            this.motivoTipo = motivoTipo;
        }


        //ESTO ES SOLO PARA PROBAR
        public string getComentario() => comentario;
        public MotivoTipo getMotivoTipo() => motivoTipo;
    }
}
