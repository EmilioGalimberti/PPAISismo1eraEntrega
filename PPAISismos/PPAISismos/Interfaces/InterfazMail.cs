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

    public class InterfazMail
    {
        // Métodos:
        public void enviarMail(int identificadorSismografo, string nombreEstadoSismografoFueraServicio, DateTime fechaHoraActual, List<(MotivoTipo motivo, string comentario)> motivosSeleccionadosConComentarios, string email)
        {
            MessageBox.Show($"Correo enviado a {email}.\n" +
                            $"Sismógrafo: {identificadorSismografo}\n" +
                            $"Estado: {nombreEstadoSismografoFueraServicio}\n" +
                            $"Fecha y hora: {fechaHoraActual}\n" +
                            $"Motivos:\n" +
                            $"{string.Join("\n", motivosSeleccionadosConComentarios.Select(m => $"- {m.motivo.getDescripcion()}: {m.comentario}"))}"
            );
        }
    }
}