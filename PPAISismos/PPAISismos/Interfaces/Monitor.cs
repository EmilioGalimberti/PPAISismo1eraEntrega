using PPAISismos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAISismos.Interfaces
{

    public class Monitor
    {
        // Métodos:
        public void publicar(int identificadorSismografo, string nombreEstadoSismografoFueraServicio, DateTime fechaHoraActual, List<(MotivoTipo motivoTipo, string comentario)> motivosSeleccionadosConComentarios)
        {
            MessageBox.Show("Publicación hecha...");
        }
    }
}