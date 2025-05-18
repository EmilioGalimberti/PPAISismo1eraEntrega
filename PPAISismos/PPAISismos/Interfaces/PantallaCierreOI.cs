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
    public partial class PantallaCierreOI : Form
    {
        //atributos
        private GestorCierreIO gestor { get; set; }
        
        //Este es el constructor no?
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
            //creamos un gestor y le pasamos esta pantalla, para hacer la dependencia
            gestor = new GestorCierreIO(this);
            gestor.cerrarOI();
        }

        //Grilla para mostrar las OI
        public void solicitarSeleccionOI(List<(OrdenDeInspeccion, int, string)> lista)
        {
            dataGridOrdenes.Visible = true;
            dataGridOrdenes.Rows.Clear();

            // Opcional: si no tienes columnas definidas en el diseñador, agrégalas así:
            if (dataGridOrdenes.Columns.Count == 0)
            {
                dataGridOrdenes.Columns.Add("NumeroOrden", "N° Orden");
                dataGridOrdenes.Columns.Add("FechaFinalizacion", "Fecha Finalizacion");
                dataGridOrdenes.Columns.Add("NombreEstacion", "Nombre Estación");
                dataGridOrdenes.Columns.Add("IdentificadoSismografo", "Identificador Sismografo");
            }

            foreach (var tupla in lista)
            {
                dataGridOrdenes.Rows.Add(
                    tupla.Item1.getNumeroOrden(),
                    tupla.Item1.getFechaFinalizacion(),
                    tupla.Item3,
                    tupla.Item2
                    
                );
            }
        }

        private void PantallaCierreOI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
