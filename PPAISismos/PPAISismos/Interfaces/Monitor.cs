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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PPAISismos.Interfaces
{

    public class Monitor
    {
        // Métodos:
        public void publicar(int nroMonitor,int identificadorSismografo, string nombreEstadoSismografoFueraServicio, DateTime fechaHoraActual, List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios)
        {
            MessageBox.Show($"MONITOR {nroMonitor}\n" +
                            $"Sismógrafo: {identificadorSismografo}\n" +
                            $"Estado: {nombreEstadoSismografoFueraServicio}\n" +
                            $"Fecha y hora: {fechaHoraActual}\n" +
                            $"Motivos:\n" +
                            $"{string.Join("\n", motivosSeleccionadosConComentarios.Select(m => $"- {m.motivo.getDescripcion()}: {m.comentario}"))}"
            );
        }
    }
}