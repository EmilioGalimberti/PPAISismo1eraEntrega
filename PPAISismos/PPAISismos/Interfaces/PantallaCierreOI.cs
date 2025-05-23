using PPAISismos.Entidades;
using PPAISismos.Gestor;
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
    // Clase que representa la pantalla de cierre de la orden de inspección (OI)
    public partial class PantallaCierreOI : Form
    {
        // Atributos: 
        private GestorCierreOI gestorCerrarOI { get; set; }

        //PARA PODER MANEJAR LOS INDICES CON LOS CHECKBOX
        private List<int> indicesMotivosSeleccionados;
        private int motivoActualIndex = 0;
        private List<(int motivoIndex, string comentario)> motivosYComentarios = new List<(int, string)>();

        // Constructor de la pantalla
        public PantallaCierreOI()
        {
            seleccionOpcionCerrarOI();


        }

        //aca podria hacer un button pero PREGUNTAR

        private void seleccionOpcionCerrarOI()
        {
            InitializeComponent();
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            // Creamos un gestor y le pasamos esta pantalla, para hacer la dependencia
            gestorCerrarOI = new GestorCierreOI(this);
            gestorCerrarOI.cerrarOI();
        }

        // Método para solicitar la selección de la OI
        public void solicitarSeleccionOI(List<(int NumeroOrden, DateTime FechaFinalizacion, string NombreEstacion, int IdentificadorSismografo)> lista)
        {
            dataGridOrdenes.Visible = true;
            dataGridOrdenes.Rows.Clear();

            // Si no hay columnas definidas en el diseñador, las agregamos
            if (dataGridOrdenes.Columns.Count == 0)
            {
                dataGridOrdenes.Columns.Add("NumeroOrden", "N° de Orden");
                dataGridOrdenes.Columns.Add("FechaFinalizacion", "Fecha de Finalización");
                dataGridOrdenes.Columns.Add("NombreEstacion", "Nombre de la Estación Simológica");
                dataGridOrdenes.Columns.Add("IdentificadorSismografo", "Identificador del Sismógrafo");

                // Deshabilitar el ordenamiento en los headers
                foreach (DataGridViewColumn col in dataGridOrdenes.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

            foreach (var tupla in lista)
            {
                dataGridOrdenes.Rows.Add(
                    tupla.NumeroOrden,
                    tupla.FechaFinalizacion,
                    tupla.NombreEstacion,
                    tupla.IdentificadorSismografo
                );
            }

            //Esto es para que se ajuste el tamaño de la tabla a los datos
            dataGridOrdenes.AutoResizeColumns();
            dataGridOrdenes.AutoResizeRows();
            dataGridOrdenes.Width = dataGridOrdenes.PreferredSize.Width;
            dataGridOrdenes.Height = dataGridOrdenes.PreferredSize.Height;

        }

        private void PantallaCierreOI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar el header
            {
                ordenSeleccionada(e.RowIndex);
            }
            ;

        }

        private void ordenSeleccionada(int row)
        {
            gestorCerrarOI.tomarOrdenSeleccionada(row);
        }

        //Para la observacion de cierre
        public void solicitarObservacion(int numeroOrden)
        {
            //ACA PARA EL LABEL DE INGRESE UNA OBSERVACION LE PODRIA PEDIR QUE INGRESE UNA OBSERVACION y a que orden le estaria ingresando la observacion pero significaria pasarle la oi seleccionada
            //y nose si estaria del todo bien para los atributos de la pantalla, De ultima podemos preguntar
            labelObservacion.Text = $"Ingrese una observación para la orden seleccionada: {numeroOrden}";
            labelObservacion.Visible = true;
            textBoxObservaciones.Visible = true;
            btnGuardarObservacion.Visible = true;

        }

        private void btnGuardarObservacion_Click(object sender, EventArgs e)
        {
            string observacion = textBoxObservaciones.Text;

            if (string.IsNullOrEmpty(observacion))
            {
                MessageBox.Show("Debe ingresar una observación antes de guardar.", "Observación requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxObservaciones.Focus();
                return;
            }
            


            observacionIngresada(observacion);
        }

        private void observacionIngresada(string observacion)
        {
            gestorCerrarOI.tomarObservacion(observacion);
        }

        //Para los TIPOS DE MOTIVOS
        public void solicitarSeleccionTipoMotivo(List<string> motivos)
        {
            labelMotivosFueraServicio.Visible = true;
            checkedListBoxMotivos.Items.Clear();
            foreach (var motivo in motivos)
                checkedListBoxMotivos.Items.Add(motivo);

            checkedListBoxMotivos.Visible = true;
            buttonConfirmarMotivos.Visible = true;
        }

        // Evento del botón para confirmar selección de motivos
        private void buttonConfirmarMotivos_Click(object sender, EventArgs e)
        {
            seleccionTipoMotivo();
            
        }

        private void seleccionTipoMotivo()
        {
            // Guarda los índices de los motivos seleccionados
            //Cuando el usuario confirma los motivos seleccionados (buttonConfirmarMotivos_Click), guardas los índices de los motivos seleccionados y reseteas el índice del motivo actual:
            indicesMotivosSeleccionados = checkedListBoxMotivos.CheckedIndices.Cast<int>().ToList();
            motivoActualIndex = 0;
            motivosYComentarios.Clear();

            if (indicesMotivosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un motivo.", "Motivo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Comienza el loop de comentarios
            solicitarComentarioParaMotivoActual();
        }

        private void solicitarComentarioParaMotivoActual()
        {
            
            if (motivoActualIndex < indicesMotivosSeleccionados.Count)
            {
                // Muestra el motivo actual y pide comentario
                int idx = indicesMotivosSeleccionados[motivoActualIndex];
                string motivoDescripcion = checkedListBoxMotivos.Items[idx].ToString();
                labelComentario.Text = $"Ingrese un comentario para: {motivoDescripcion}";
                labelComentario.Visible = true;
                textBoxComentario.Visible = true;
                btnGuardarComentario.Visible = true;
                btnGuardarComentario.Enabled = true;
                textBoxComentario.Text = "";
                textBoxComentario.Focus();
            }
            else
            {
                // Cuando termina, envía la lista al gestor
                // Fin del loop: envía la lista de motivos y comentarios al gestor
                ingresarComentario(motivosYComentarios);
                
            }
        }

        private void ingresarComentario(List<(int motivoIndex, string comentario)> motivosYComentarios) {
            gestorCerrarOI.tomarMotivosYComentarios(motivosYComentarios);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            string comentario = textBoxComentario.Text.Trim();
            if (string.IsNullOrEmpty(comentario))
            {
                MessageBox.Show("Debe ingresar un comentario.", "Comentario requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            // Validar que el índice esté dentro del rango
            if (motivoActualIndex < indicesMotivosSeleccionados.Count)
            {
                // Guarda el comentario junto al índice del motivo
                //Cuando el usuario ingresa un comentario y presiona el botón, se guarda el comentario y se incrementa el índice:
                motivosYComentarios.Add((indicesMotivosSeleccionados[motivoActualIndex], comentario));
                motivoActualIndex++;
                solicitarComentarioParaMotivoActual();
            }
            else
            {
                // Ya no hay más motivos, puedes deshabilitar el botón o mostrar un mensaje
                btnGuardarComentario.Enabled = false;
                MessageBox.Show("Ya se ingresaron comentarios para todos los motivos seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void solicitarConfirmacion()
        {
            
            btnConfirmarCierreOI.Visible= true;

        }

        private void btnConfirmarCierreOI_Click(object sender, EventArgs e)
        {
            //Podria agregar un warning que si confirma no va a poder editar nada mas
            confirmar();
        }

        private void confirmar()
        {
            // Deshabilitar controles para evitar más cambios
            dataGridOrdenes.Enabled = false;
            textBoxObservaciones.Enabled = false;
            btnGuardarObservacion.Enabled = false;
            checkedListBoxMotivos.Enabled = false;
            buttonConfirmarMotivos.Enabled = false;
            textBoxComentario.Enabled = false;
            btnGuardarComentario.Enabled = false;

            gestorCerrarOI.tomarConfirmacion();

        }
    }
}
