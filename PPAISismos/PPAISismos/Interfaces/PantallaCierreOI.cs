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
        private GestorCierreIO gestor { get; set; }
        
        // Constructor de la pantalla
        public PantallaCierreOI()
        {
            seleccionOpcionCerrarOI();
            

        }
        
        private void seleccionOpcionCerrarOI()
        {
            InitializeComponent();
            habilitarPantalla();
        }

        private void habilitarPantalla() {
            // Creamos un gestor y le pasamos esta pantalla, para hacer la dependencia
            gestor = new GestorCierreIO(this);
            gestor.cerrarOI();
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
            gestor.tomarOrdenSeleccionada(row);
        }

        //Para la observacion de cierre
        public void solicitarObservacion(int numeroOrden)
        {
            //ACA PARA EL LABEL DE INGRESE UNA OBSERVACION LE PODRIA PEDIR QUE INGRESE UNA OBSERVACION y a que orden le estaria ingresando la observacion pero significaria pasarle la oi seleccionada
            //y nose si estaria del todo bien para los atributos de la pantalla, De ultima podemos preguntar
            labelObservacion.Text = $"Ingrese una observación para la orden seleccionada: {numeroOrden}";
            labelObservacion.Visible = true;
            textBoxObservaciones.Visible = true;

        }

    }
}
