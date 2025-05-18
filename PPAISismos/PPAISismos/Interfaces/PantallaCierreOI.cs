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
            Sesion sesion = Data.Data.loadSesion();
            habilitarPantalla(sesion);
        }

        private void habilitarPantalla(Sesion sesion) {             
            //creamos un gestor y le pasamos esta pantalla, para hacer la dependencia
            gestor = new GestorCierreIO(this,sesion);
            gestor.cerrarOI();
        }

        private void PantallaCierreOI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
